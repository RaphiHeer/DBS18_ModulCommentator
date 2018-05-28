using ModulCommentatorModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace ModulCommentatorViewModel
{
    public class SpecialQueryViewModel : INotifyPropertyChanged
    {
        private SpecialQueryModel queryModel;
        private List<Dozent> _dozenten;
        private List<Dozent> _dozentModulCountList;
        private Dozent _selectedDozent;

        private ICommand executeCountQuery;

        public SpecialQueryViewModel(SpecialQueryModel queryModel)
        {
            this.queryModel = queryModel;
            this.OnPropertyChanged("DozentenList");

            this.executeCountQuery = new RelayCommand(GetQueryList, param => true);
        }

        public void GetQueryList(object obj)
        {
            if (this._selectedDozent != null)
            {
                this.queryModel.getDozentCountQuery(_selectedDozent);
            }
        }

        public List<Dozent> DozentenList
        {
            get { return queryModel.GetAllDozents(); }
            set
            {
                if (_dozenten != value)
                {
                    _dozenten = value;
                }
            }
        }

        public Dozent SelectedDozent
        {
            get
            {
                return _selectedDozent;
            }
            set
            {
                _selectedDozent = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ExecuteCountQuery
        {
            get
            {
                return executeCountQuery;
            }
            set
            {
                executeCountQuery = value;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
