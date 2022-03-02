using HR_Management_Software.Models;
using MongoDB.Driver;

namespace HR_Management_Software.Repositories
{
    public class MongoDBEmployees : IEmployeeRepository
    {
        private const string databaseName = "catalog";
        private const string collectionName = "employees";
        private readonly IMongoCollection<Employee> employeeCollection;
        public MongoDBEmployees(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            employeeCollection = database.GetCollection<Employee>(collectionName);
        }
        void IEmployeeRepository.CreateEmployee(Employee employee)
        {
            employeeCollection.InsertOne(employee);
        }

        void IEmployeeRepository.DeleteEmloyee(Guid id)
        {
            throw new NotImplementedException();
        }

        Employee IEmployeeRepository.GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IEmployeeRepository.GetEmployees()
        {
            throw new NotImplementedException();
        }

        void IEmployeeRepository.UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }


}