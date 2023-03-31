using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
	public class NetworkApp
	{
		private NewsFeed news = new NewsFeed();


		/// <summary>
		/// 
		/// </summary>
		public void DisplayMenue()
		{
			OutputHeading();

			string[] choices = new string[]
			{
				"Post Message", "Post Image", "" +
				"DisplayMenu All Posts", "Remove Post", "Quit"
            };

			bool wantToQuit = false;

			do
			{
				int choice = ConsoleHelper.SelectChoice(choices);

				switch (choice)
				{
					case 1: PostMessage(); break;
					case 2: PostImage(); break;
					case 3: DisplayAll(); break;
					case 4: RemovePost(); break;
					case 5: wantToQuit = true; break;
				}

			} while (!wantToQuit);
		}

		private void OutputHeading()
		{
			Console.WriteLine();
			Console.WriteLine(" =====================================================");
			Console.WriteLine("            News Feed                     ");
			Console.WriteLine("            by Crown Caesar                           ");
			Console.WriteLine(" =====================================================");
			Console.WriteLine();

		}

		private void DisplayAll()
		{
			news.Display();
		}

		private void PostImage()
		{
			ConsoleHelper.OutputTitle("Posting an Image/Photo");

			string author = InputName();

			Console.WriteLine("");
			Console.WriteLine("Please enter your image filename > ");
			string filename = Console.ReadLine();

			Console.WriteLine("");
			Console.WriteLine("Please enter your image caption > ");
			string caption = Console.ReadLine();

			PhotoPost post = new PhotoPost(author, filename, caption);
			news.AddPhotoPost(post);
			post.Display();

			PostSuccessMessage();
		}

		private void PostMessage()
		{
			ConsoleHelper.OutputTitle("Posting a Message");

			string author = InputName();

			Console.WriteLine("");
			Console.WriteLine("Please enter your Message > ");
			string message = Console.ReadLine();

			MessagePost post = new MessagePost(author, message);
			news.AddMessagePost(post);

			ConsoleHelper.OutputTitle("Your Message has successfully been posted");

			post.Display();
		}

		private string InputName()
		{
			Console.WriteLine("Please enter your name > ");
			string author = Console.ReadLine();

			return author;
		}

		private void DisplayByDate()
		{
			throw new NotImplementedException();
		}

        private void DisplayByAuthor()
        {
			throw new NotImplementedException();

        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

			int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ",
				1, Post.GetNumberOfPosts());

            Console.WriteLine("");

            news.RemovePost(id);
        }

        private void PostSuccessMessage()
        {
            Console.WriteLine("Your Post has successfully been uploaded");
        }
    }
}

