using System;
using System.Collections.Generic;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    internal class Model1Enities : IDisposable

    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public partial class Person
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Person()
            {
                this.Answers = new HashSet<Answer>();
            }

            public System.Guid Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Patronymic { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public bool HasJob { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Answer> Answers { get; set; }
        }
    }
}