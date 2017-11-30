using PageObjcectTests;
using System;
using Xunit;

namespace PageObjectTests
{
    public class AddingBlogCommentsTests : IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.Open();

            MainPage.OpenFirstNote();
            NotePage.AddComment(new Comment

            {
                Text = "Lorem ipsum dolor sit",
                Mail = "test@test.com",
                User = "białko"
            });
                                  
            // Sprawdź, że komentarz się dodał
        }
        

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
