using ATP.Data;
using ATP.Data.Contexts;
using ATP.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ATP.AppGUI
{
    public partial class ATPGUI : Form
    {
        public ATPGUI()
        {

            InitializeComponent();
            ATPGUI_Load();
        }
        int? currentId = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var con = new FacilityDbContext())
            {
                if (currentId == null)
                {
                    btnSave.Text = "Kaydet";
                    try
                    {
                        Facility? existedFac = con.FindWithName(txtName.Text);
                        if (existedFac != null)
                        {
                            bool sameLocation = existedFac.Adress.City == txtCity.Text;
                            if (sameLocation)
                                throw new Exception("Aynı şehirde aynı isimle tesis oluşturulamaz");
                        }

                        Facility facilityToAdd = new Facility
                        {
                            Name = txtName.Text,
                            Adress = new Adress { City = txtCity.Text, Town = txtTown.Text, AdresBilgisi = txtAdresBilgisi.Text },
                            Description = txtDescription.Text,
                            InitialInvCost = decimal.Parse(txtInitInvCost.Text),
                            YearlyCost = decimal.Parse(txtYearlyCost.Text),
                            YearlyAverageProfit = decimal.Parse(txtYearlyProfit.Text),
                            Rented = chkBoxRent.Checked,
                            YearlyRentCost = decimal.Parse(txtYearlyRent.Text)
                        };

                        var validator = new FacilityValidator(facilityToAdd);
                        if (!validator.Validated)
                        {
                            var mesages = string.Join("\n", validator.Messages);
                            throw new Exception(mesages);
                        }
                        con.Add(facilityToAdd);
                        MessageBox.Show($"{facilityToAdd.Name} eklendi");
                        ResetForm();
                        ATPGUI_Load();
                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }
                }
                else
                {
                    Facility? fac = con.Facilities.Include(fac => fac.Adress).Where(x => x.Id == currentId).FirstOrDefault();
                    if (fac != null)
                    {
                        btnSave.Text = "Güncelle";
                        fac.Adress = new Adress { AdresBilgisi = txtAdresBilgisi.Text, Town = txtTown.Text, City = txtCity.Text };
                        fac.Name = txtName.Text;
                        fac.Description = txtDescription.Text;
                        fac.YearlyCost = decimal.Parse(txtYearlyCost.Text);
                        fac.InitialInvCost = decimal.Parse(txtInitInvCost.Text);
                        fac.YearlyAverageProfit = decimal.Parse(txtYearlyProfit.Text);
                        fac.Rented = chkBoxRent.Checked;
                        fac.YearlyRentCost = decimal.Parse(txtYearlyRent.Text);
                        con.Update(fac);
                        MessageBox.Show(fac.Name + " Güncellendi");
                        ATPGUI_Load();

                    }
                }
            }

        }

        private void ATPGUI_Load()
        {

            using (var con = new FacilityDbContext())
            {
                var liste = con.Facilities.Select(f => new
                {
                    f.Name,
                    f.Description,
                    f.Adress.City,
                    f.Adress.Town,
                    f.Id
                }).ToList();
                facilityDgv.DataSource = liste;
                facilityDgv.Columns[0].Width = 150;
                facilityDgv.Columns[1].Width = 150;
            }
        }

        private void facilityDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void facilityDgv_DoubleClick(object sender, EventArgs e)
        {
            if (facilityDgv.CurrentRow.Index != -1)
            {
                int id = int.Parse(facilityDgv.CurrentRow.Cells[4].Value.ToString());
                currentId = id;
                using (var con = new FacilityDbContext())
                {
                    btnSave.Text = "Güncelle";
                    txtName.Text = facilityDgv.CurrentRow.Cells[0].Value.ToString();
                    txtDescription.Text = facilityDgv.CurrentRow.Cells[1].Value.ToString();
                    txtCity.Text = facilityDgv.CurrentRow.Cells[2].Value.ToString();
                    txtTown.Text = facilityDgv.CurrentRow.Cells[3].Value.ToString();
                    Facility fac = con.Facilities.First(x => x.Id == currentId);
                    txtInitInvCost.Text = fac.InitialInvCost.ToString();
                    txtYearlyCost.Text = fac.YearlyCost.ToString();
                    txtYearlyProfit.Text = fac.YearlyAverageProfit.ToString();
                    chkBoxRent.Checked = fac.Rented;
                    txtYearlyRent.Text = fac.YearlyRentCost.ToString();
                    dynamic YearCounter = 0;
                    decimal? totalProfit = 0;

                    int? kiraDonus = (int?)(fac.InitialInvCost / fac.YearlyRentCost);

                    if (fac.YearlyCost <= fac.YearlyAverageProfit)
                    {
                        while ((YearCounter + 1) * fac.YearlyCost > totalProfit)
                        {
                            YearCounter++;
                            totalProfit += fac.YearlyAverageProfit;
                        }
                    }
                    else { YearCounter = "sonsuz"; }
               
                    if (kiraDonus <= 20)
                    {
                        txtReturnOfInvesment.Text = $"Maliyet Geri Dönüşü: {YearCounter} yıl \n Yapı Geri Dönüşü {kiraDonus} yıl";
                    }
                    else
                    {
                        if (fac.Rented)
                        {
                            txtReturnOfInvesment.Text = $"Maliyet Geri Dönüşü: {YearCounter} yıl \n Yapı Geri Dönüşü {kiraDonus} yıl";
                        }
                        else
                        {
                            txtReturnOfInvesment.Text = $"Maliyet Geri Dönüşü: {YearCounter} yıl \n Bu tesis kiralık olmalıdır.";

                        }
                    }

                }


            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void ResetForm()
        {
            btnSave.Text = "Kaydet";
            currentId = null; txtName.Text = null;
            txtDescription.Text = null;
            txtCity.Text = null;
            txtTown.Text = null;
            txtInitInvCost.Text = null;
            txtYearlyCost.Text = null;
            txtYearlyProfit.Text = null;
            txtReturnOfInvesment.Text = null;
            txtYearlyRent.Text = null;
            chkBoxRent.Checked = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_2(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new FacilityDbContext())
                {
                    Facility? fac = con.Facilities.Where(f => f.Id == currentId).FirstOrDefault();
                    if (fac == null)
                    {
                        throw new Exception("Bu tesis bulunamadı");
                    }
                    var name = fac.Name;
                    con.Remove(fac);
                    con.SaveChanges();
                    ResetForm();
                    ATPGUI_Load();
                    currentId = null;
                    MessageBox.Show($"{fac.Name} Başarıyla Silindi");

                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}