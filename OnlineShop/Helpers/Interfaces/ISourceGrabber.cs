using OnlineShop.Models;
using System.Collections.Generic;

namespace OnlineShop.Helpers.Interfaces
{
    public interface ISourceGrabber
    {
        IEnumerable<SourceItem> GetItems(IDataParser parcer, string path);
    }
}
