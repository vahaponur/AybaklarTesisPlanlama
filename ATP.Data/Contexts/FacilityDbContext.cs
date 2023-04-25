using ATP.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP.Data.Contexts
{
    public class FacilityDbContext:ATPDbContext
    {
        public FacilityDbContext()
        {
            
        }
        public void Add(Facility facility)
        {
            
            Facilities.Add(facility);
            SaveChanges();
        }
        public void Delete(Facility facility) 
        { 
            Facilities.Remove(facility);
            SaveChanges();
        }
        public Facility? FindWithName(string name)
        {
            return Facilities.Include(f=>f.Adress).Where(f => f.Name == name).FirstOrDefault();
        }
        public Facility? FindWithCity(string City)
        {
          return  Facilities.Where(f => f.Adress.City == City).FirstOrDefault();
        }
        public List<Facility> FindAllWithCity(string City)
        {
            return Facilities.Where(f => f.Adress.City == City).ToList();
        }
        public Facility? FindWithTown(string City,string Town)
        {
            return Facilities.Where(f => f.Adress.City == City && f.Adress.Town ==Town).FirstOrDefault();
        }
        public List<Facility> FindAllWithTown(string City,string Town)
        {
            return Facilities.Where(f => f.Adress.City == City && f.Adress.Town == Town).ToList();
        }
        public void Update(Facility facility)
        {
            try
            {
          
                if (Facilities.Where(f=>f.Id==facility.Id).FirstOrDefault() ==null)
                {
                    throw new Exception("Bu tesis bulunamadı");
                }
                Facilities.Update(facility);
                SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
       
        }
     

    }
}
