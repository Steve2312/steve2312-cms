using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Extensions;

public static class KeyFieldExtensions
{
    public static IEnumerable<KeyValuePair<KeyField<T>, ValueField<T>?>> MapValueFields<T>(
        this IEnumerable<KeyField<T>> keyFields,
        IEnumerable<ValueField<T>> valueFields
    ) 
    {
        return (
            from keyField in keyFields
            join valueField in valueFields
                on keyField.Id equals valueField.KeyFieldId into field 
            from valueField in field.DefaultIfEmpty()
            select new KeyValuePair<KeyField<T>, ValueField<T>?>(keyField, valueField)
        );
    }
}