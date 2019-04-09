using System.Collections.Generic;
using System.Linq;

namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry timeEntry);
        TimeEntry Find(long id);
        bool Contains(long id);
        IEnumerable<TimeEntry> List();
        TimeEntry Update(long id, TimeEntry timeEntry);
        void Delete(long id);
    }
}