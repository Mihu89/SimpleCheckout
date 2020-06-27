using SimpleCheckout.Entities;
using SimpleCheckout.Interfaces;
using SimpleCheckout.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SimpleCheckout.Repository
{
    public class MobileRepo : IBaseRepo<Mobile>, IMobileRepo
    {
        private ApplicationDbContext _context; 
        public MobileRepo()
        {
            _context = new ApplicationDbContext();
        }
        public void Delete(Mobile t)
        {
            _context.Mobiles.Remove(t);
        }

        public Mobile GetById(int id)
        {
            return _context.Mobiles.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public List<Mobile> GetAll()
        {
            return _context.Mobiles.AsNoTracking().ToList();
        }

        public int GetIdByName(Mobile t)
        {
            return _context.Mobiles.AsNoTracking()
                .FirstOrDefault(x => x.Name == t.Name).Id;
        }

        public void Update(Mobile t, int id)
        {
            //var mobileToUpdate = GetById(id);
            //mobileToUpdate.Name = t.Name;
            //mobileToUpdate.Price = t.Price;
            //mobileToUpdate.Url = t.Url;
            //mobileToUpdate.ZoomUrl = t.ZoomUrl;
            //mobileToUpdate.Description = t.Description;
            //_context.SaveChanges();

            _context.Mobiles.AddOrUpdate(t);
            _context.SaveChanges();
        }
    }
}