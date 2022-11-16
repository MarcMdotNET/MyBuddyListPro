using MyBuddyListPro.Models;

namespace MyBuddyListPro.Services.Interfaces
{
    public interface IAddressBookService
    {
        Task AddContactToCategoryAsync(int categoryId, int contactId);
        Task<bool> IsContactInCategory(int categoryId, int contactId);
        Task<IEnumerable<Category>> GetUserCategoriesAsync(string userId);
        Task<ICollection<Category>> GetContactCategoriesAsync(int contactId);
        Task<ICollection<int>> GetContactCategoryIdsAsync(int contactId);
        Task RemoveContactFromCategoryAsync(int categoryId, int contactId);
        IEnumerable<Contact> SearchForContacts(string searchString, string userId);
    }
}
