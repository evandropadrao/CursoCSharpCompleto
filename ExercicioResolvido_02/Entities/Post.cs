using System;
using System.Text;
using System.Collections.Generic;

namespace ExercicioResolvido_02.Entities
{
   class Post
   {
      public DateTime Moment { get; set; }
      public string Title { get; set; }
      public string Content { get; set; }
      public int Likes { get; set; }
      public List<Comment> Comments { get; set; } = new List<Comment>();

      public Post()
      {
      }

      public Post(DateTime moment, string title, string content, int likes)
      {
         Moment = moment;
         Title = title;
         Content = content;
         Likes = likes;
      }

      public void AddComment(Comment comment)
      {
         Comments.Add(comment);
      }

      public void RemoveComment(Comment comment)
      {
         Comments.Remove(comment);
      }

      public override string ToString()
      {
         StringBuilder text = new StringBuilder();

         text.AppendLine(Title);
         text.AppendLine($"{Likes} likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
         text.AppendLine(Content);
         text.AppendLine("Coments:");

         foreach (var comment in Comments)
         {
            text.AppendLine(comment.text);
         }

         return text.ToString();
      }
   }
}
