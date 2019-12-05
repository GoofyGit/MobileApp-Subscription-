using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Project2Forms
{
    public class appDb
    {
        public static void ensureCreated()
        {
            using(var db = new dataContext()){
                db.Database.EnsureCreated();
            }
        }

        public static List<dbEntry> getAll()
        {
            List<dbEntry> allItems = new List<dbEntry>();

            using (var db = new dataContext()){
                allItems = db.appInfo.ToList();
            }

            return (allItems);
        }

        public static dbEntry getById(int id)
        {
            dbEntry item;

            using(var db = new dataContext()){
                item = db.appInfo.Where(x => x.dbEntryID == id).First();
            }

            return (item);
        }

        public static void addItem(string _subName, DateTime _dueTime, double _cost)
        {
            dbEntry itemToAdd = new dbEntry()
            {
                subName = _subName,
                dueDate = _dueTime,
                amount = _cost
            };

            using(var db = new dataContext()){
                db.appInfo.Add(itemToAdd);
                db.SaveChangesAsync();
            }
        }
    }
}