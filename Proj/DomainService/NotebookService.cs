using Proj.Models.DbModels;
using Proj.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Proj.DomainService
{
    public class NotebookService
    {
        private readonly ApplicationDbContext _context;
        public NotebookService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<PC> getAllNotebooks(PcFiltrEnum filtrEnum)
        {
            var pc = _context
                .PC
                .Include(x => x.AssignedUser)
                .WhereIf(filtrEnum == PcFiltrEnum.Acctive,x => x.Acctive)
                .WhereIf(filtrEnum == PcFiltrEnum.NotAcctive, x => !x.Acctive)
                .ToList();
            return pc;
        }
        public void addNotebook(PC pcToAdd) 
        {
            _context.PC.Add(pcToAdd);
            _context.SaveChanges();
        }
        public void updateNotebook(PC pcUpdate) 
        {
            _context.PC.Update(pcUpdate);
            _context.SaveChanges();
        }
    }
        

}

public enum PcFiltrEnum 
{
    None,
    Acctive,
    NotAcctive,
}
public static class LinqExtension
{
    public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> whereClause)
    {
        return condition ? query.Where(whereClause) : query;
    }
}

