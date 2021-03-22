using CustomerManagement.IDAL.IContact;
using CustomerManagement.Model;
using CustomerManagement.Model.Contact;

namespace CustomerManagement.DAL.Contact
{
    /// <summary>
    ///  实现联系人  DAL
    /// </summary>
    public class ContactPersonService:BaseService<ContactPerson>,IContactPersonService
    {
        public ContactPersonService() : base(new CustomerManagementContext())
        {

        }
    }
}
