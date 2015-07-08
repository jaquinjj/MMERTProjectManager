using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;


namespace MMERT.DATA
{
    public static class SelectListExtension
    {
        public static List<SelectListItem> ToSelectList<T>(this IEnumerable<T> itemsToMap, Func<T, string> textProperty, Func<T, string> valueProperty, Predicate<T> isSelected)
        {
            return itemsToMap.Select(item => new SelectListItem
            {
                Value = valueProperty(item),
                Text = textProperty(item),
                Selected = isSelected(item)
            }).ToList();
        }
    }
}
