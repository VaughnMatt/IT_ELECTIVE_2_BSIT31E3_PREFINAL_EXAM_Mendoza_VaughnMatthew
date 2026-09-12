using IT_ELECTIVE_2_PREFINAL_EXAM_Mendoza_Vaughn.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_PREFINAL_EXAM_Mendoza_Vaughn.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<ExamQuestion>
            {
                new ExamQuestion
                {
                    Number = 1,
                    Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Answer = "C — It allows data to persist after the application stops1"
                },

                new ExamQuestion
                {
                    Number = 2,
                    Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Answer = "B. Database-First2"
                },

                new ExamQuestion
                {
                    Number = 3,
                    Question = "What is the primary purpose of Entity Framework Core?",
                    Answer = "C. To map objects in code to relational database data3"
                },

                new ExamQuestion
                {
                    Number = 4,
                    Question = "Which EF Core component is primarily responsible for communicating with the database?",
                    Answer = "A. 4DbContext"
                },

                new ExamQuestion
                {
                    Number = 5,
                    Question = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Answer = "5C. Generates EF Core models and a DbContext from an existing database"
                },

                new ExamQuestion
                {
                    Number = 6,
                    Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Answer = "6B. appsettings.json"
                },

                new ExamQuestion
                {
                    Number = 7,
                    Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Answer = "7B. One-to-Many"
                },

                new ExamQuestion
                {
                    Number = 8,
                    Question = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                    Answer = "8B. Foreign key referencing Section"
                },

                new ExamQuestion
                {
                    Number = 9,
                    Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Answer = "9B. It represents a relationship to another entity"
                },

                new ExamQuestion
                {
                    Number = 10,
                    Question = "What does .Include() generally allow EF Core to do?",
                    Answer = "B. Load related Section data together with Students"
                },

                new ExamQuestion
                {
                    Number = 11,
                    Question = "Why might a ViewModel be used when displaying Student and Section information?",
                    Answer = "B. To combine or shape the data specifically needed by the view"
                },

                new ExamQuestion
                {
                    Number = 12,
                    Question = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?",
                    Answer = "A. It loads the related Section navigation property"
                },

                new ExamQuestion
                {
                    Number = 13,
                    Question = "Which type of validation occurs in the browser before a request is sent to the server?",
                    Answer = "B. Client-side validation"
                },

                new ExamQuestion
                {
                    Number = 14,
                    Question = "Why is server-side validation still necessary if client-side validation exists?",
                    Answer = "A. Client-side validation can be bypassed"
                },

                new ExamQuestion
                {
                    Number = 15,
                    Question = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    Answer = "B. Student Number should be unique"
                },

                new ExamQuestion
                {
                    Number = 16,
                    Question = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                    Answer = "A. It protects data integrity even if application-level validation is bypassed"
                },

                new ExamQuestion
                {
                    Number = 17,
                    Question = "What is the purpose of a try...catch block in a controller?",
                    Answer = "B. To catch and handle exceptions that may occur during execution"
                },

                new ExamQuestion
                {
                    Number = 18,
                    Question = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                    Answer = "B. UseExceptionHandler()"
                },

                new ExamQuestion
                {
                    Number = 19,
                    Question = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                    Answer = "B. Display a Not Found (404) response/page"
                },

                new ExamQuestion
                {
                    Number = 20,
                    Question = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                    Answer = "A. Data integrity"
                }
            };

            return View(questions);
        }
    }
}