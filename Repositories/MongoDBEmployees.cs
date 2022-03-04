using HR_Management_Software.Models;
using MongoDB.Bson;
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
            employeeCollection.DeleteOne(employee => employee.Id == id);
        }

        Employee IEmployeeRepository.GetEmployee(Guid id)
        {
            return employeeCollection.Find(employee => employee.Id == id).FirstOrDefault();
        }

        IEnumerable<Employee> IEmployeeRepository.GetEmployees()
        {
            return employeeCollection.Find(new BsonDocument()).ToList();
        }

        void IEmployeeRepository.UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }


}