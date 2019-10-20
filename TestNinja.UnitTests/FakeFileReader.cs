using System;
using _5_3_RefactoringTowardsALoosely_coupledDesign.Mocking;

namespace TestNinja.UnitTests
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
