namespace AngularWebApi.Model
{
    public class EmployeRepository
    {
        readonly AppDbContext _context;
        public EmployeRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _context.Set<Employee>().AddAsync(employee);
            await _context.SaveChangesAsync();
        }
    }
}
