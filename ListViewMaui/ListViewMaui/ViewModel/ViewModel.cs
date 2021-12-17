using System.Collections.ObjectModel;

namespace ListViewMaui
{
    public class ListViewSortingViewModel
    {
        #region Fields

        private ObservableCollection<ListViewContactsInfo> contactsInfo;

        #endregion

        #region Constructor

        public ListViewSortingViewModel()
        {
            GenerateSource(100);
        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewContactsInfo> ContactsInfo
        {
            get { return contactsInfo; }
            set { this.contactsInfo = value; }
        }

        #endregion

        #region ItemSource

        public void GenerateSource(int count)
        {
            ListViewContactsInfoRepository contactRepository = new ListViewContactsInfoRepository();
            contactsInfo = contactRepository.GetContactDetails(count);
        }

        #endregion

    }
}
