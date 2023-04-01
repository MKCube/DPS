using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Models.DbModels
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }

    }
    public interface IBaseEntity
    {
        Guid Id { get; set; }
    }
}
