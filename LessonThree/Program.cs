using LessonThree;

Title myTitle = new Title("C# for starters");
Author myAuthor = new Author("Yuri S");
Content myContent = new Content("Learn C Sharp from starter to professional");

Book myBook = new Book();

myBook.Title = myTitle.BookTitle;
myBook.Author = myAuthor.BookAuthor;
myBook.Content = myContent.BookContent;

Console.WriteLine(myBook);
