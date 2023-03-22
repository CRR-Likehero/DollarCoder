namespace DollarCoder.Models
{
    public class CoursesShop
    {
        public List<CoursesItem> CourseItems = new List<CoursesItem>();

        public CoursesShop()
        {
            CourseItems.Add(new CoursesItem(0, "JavaScript", 1, "./img/courses/javascriptcourse.jpg"));
            CourseItems.Add(new CoursesItem(1, "TypeScript", 1, "./img/courses/typescriptcourse.png"));
            CourseItems.Add(new CoursesItem(2, "PHP", 1, "./img/courses/phpcourse.png"));
            CourseItems.Add(new CoursesItem(3, "Python", 1, "./img/courses/pythoncourse.png"));
            CourseItems.Add(new CoursesItem(4, "Go", 1, "./img/courses/gocourse.png"));
            CourseItems.Add(new CoursesItem(5, "Kotlin", 1, "./img/courses/kotlincourse.png"));
            CourseItems.Add(new CoursesItem(6, "CSS", 1, "./img/courses/csscourse.jpg"));
            CourseItems.Add(new CoursesItem(7, "CSharp", 1, "./img/courses/csharpcourse.png"));
            CourseItems.Add(new CoursesItem(8, "FSharp", 1, "./img/courses/fsharpcourse.png"));
            CourseItems.Add(new CoursesItem(9, "Java", 1, "./img/courses/javacourse.png"));
            CourseItems.Add(new CoursesItem(10, "Rust", 1, "./img/courses/rustcourse.jpg"));
            CourseItems.Add(new CoursesItem(11, "Swift", 1, "./img/courses/swiftcourse.png"));
            CourseItems.Add(new CoursesItem(12, "CPlusPlus", 1, "./img/courses/cpluspluscourse.png"));
            CourseItems.Add(new CoursesItem(13, "SQL", 1, "./img/courses/sqlcourse.png"));
        }


    }
}
