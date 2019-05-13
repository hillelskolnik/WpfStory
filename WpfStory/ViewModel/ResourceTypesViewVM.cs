using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStory.Data;

namespace WpfStory.ViewModel
{
    public class ResourceTypesViewVM : NotifyChange
    {
        private bool? isAllFeatures;

        public bool? IsAllFeatures
        {
            get { return isAllFeatures; }
            set
            {
                if (isAllFeatures != value)
                {
                    isAllFeatures = value;
                    Notify("IsAllFeatures");
                    if (!value.HasValue)
                    {
                        return;
                    }
                    IsAbc = IsXyz = IsWww = value.Value;
                }
            }
        }

        private void UpdateAllFeacures()
        {
            bool? temp = null;
            if (IsAbc && IsXyz && IsWww)
            {
                temp = true;
            }
            else if (!IsAbc && !IsXyz && !IsWww)
            {
                temp = false;
            }

            IsAllFeatures = temp;
        }

        private bool isAbc;

        public bool IsAbc
        {
            get { return isAbc; }
            set
            {
                if (value == isAbc)
                {
                    return;
                }
                isAbc = value;
                Notify("IsAbc");
                UpdateAllFeacures();
            }
        }

        private bool isXyz = true;

        public bool IsXyz
        {
            get { return isXyz; }
            set
            {
                if (value == isXyz)
                {
                    return;
                }
                isXyz = value;
                Notify("IsXyz");
                UpdateAllFeacures();
            }
        }

        private bool isWww;

        public bool IsWww
        {
            get { return isWww; }
            set
            {
                if (value == isWww)
                {
                    return;
                }
                isWww = value;
                Notify("Iswww");
                UpdateAllFeacures();
            }
        }


        public ResourceTypesViewVM()
        {
        }

    }
}
