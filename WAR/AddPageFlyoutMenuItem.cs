using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAR
{
    public class AddPageFlyoutMenuItem
    {
        public AddPageFlyoutMenuItem()
        {
            TargetType = typeof(AddPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}