using AzureClasswork5.Class;
using Microsoft.EntityFrameworkCore;

using (var db = new AzureDbContext())
{
    //deleting
    //await db.Database.EnsureDeletedAsync();

    //creating
    //await db.Database.EnsureCreatedAsync();

    //Adding
    //Author author = new Author() { Id = 1, Name = "Steven", Surname = "Tester" };
    //db.Add(author);
    //await db.SaveChangesAsync();

    //Book book = new Book() { Id = 1, Title="Alchemy", AuthorId = 1};
    //db.Add(book);
    //await db.SaveChangesAsync();

    //reading from db
    //List<Author> Authors = db.Authors.AsNoTracking().ToList();
    //List<Book> Books = db.Books.AsNoTracking().ToList();

    //Console.WriteLine("Authors:");
    //foreach(var item in Authors)
    //{
    //    Console.WriteLine(item.ToString());
    //}
    //Console.WriteLine();
    //Console.WriteLine("Books:");
    //foreach (var item in Books)
    //{
    //    Console.WriteLine(item.ToString());
    //}
    //Console.WriteLine();

    //updating
    //var book = await db.Books.Where(o => o.Id == 1).FirstAsync();
    //Console.WriteLine(book.ToString());

    //book.Title = "AuthorTitle";
    //Console.WriteLine(book.ToString());
    //db.Update(book);
    //await db.SaveChangesAsync();

    //Console.WriteLine("It's created!");
}
