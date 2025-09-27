using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentDiary.Services.DTOs;

namespace StudentDiary.Services.Interfaces
{
    public interface IDiaryService
    {
        void CreateEntry(DiaryEntryCreateDTO dto);
        void UpdateEntry(DiaryEntryUpdateDTO dto);
        void DeleteEntry(int id);
        DiaryEntryReadDTO GetEntry(int id);
        IEnumerable<DiaryEntryReadDTO> GetAllEntries();
    }
}

