using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DogStore.DAL
{
    public class DogStoreContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<AddressDetails> AddressDetails { get; set; }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<Sire> Sire { get; set; }
        public DbSet<Dame> Dame { get; set; }
        public DbSet<Puppy> Puppy { get; set; }
        public DbSet<Litter> Litter { get; set; } 
    }
}
