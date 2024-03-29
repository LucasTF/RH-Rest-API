﻿using OrbiumDesafioRH.Converters.Contracts;

namespace OrbiumDesafioRH.Converters.Implementations
{
    public abstract class AbstractToModelConverter<TModel, TViewItem> : IToModelConverter<TModel, TViewItem>
        where TModel : class
        where TViewItem : class
    {
        public TModel ConvertToModel(TViewItem viewItem)
        {
            return viewItem == null ? null : NullSafeConvertToModel(viewItem);
        }

        protected abstract TModel NullSafeConvertToModel(TViewItem viewItem);
    }
}
