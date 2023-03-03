using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetoNotas.Domain.DTO
{
    public class NoteDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public CategoryEnum category { get; set; }
        public bool fixeded { get; set; }
        public DateTime timeNote { get; set; }
        public virtual User? user { get; set; }

        public Note mapToEntity()
        {
            return new Note()
            {
                Id = id,
                Title = title,
                Description = description,
                Category = category,
                Fixed = fixeded,
                TimeNote = timeNote,
                User = user,
            };
        }

        public NoteDTO mapToDTO(Note note)
        {
            return new NoteDTO()
            {
                id = note.Id,
                title = note.Title,
                description = note.Description,
                category = note.Category,
                fixeded = note.Fixed,
                timeNote = note.TimeNote,
                user = note.User,
            };
        }
    }
}
