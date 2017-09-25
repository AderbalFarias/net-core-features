using AboutNetCore.Version1_0.DefaultTemplate.Entities;
using System.Collections.Generic;

namespace AboutNetCore.Version1_0.DefaultTemplate.Services.Interfaces
{
    public interface ITesteService
    {
        IEnumerable<Test> GetAll();
        Test Get(int id);
        void Add(Test entity);
        void Update(Test entity);
        string TestViewComponent();
    }
}