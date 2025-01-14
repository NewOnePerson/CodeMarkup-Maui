﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class EventTriggerExtension
    {
        public static Microsoft.Maui.Controls.EventTrigger Actions(this Microsoft.Maui.Controls.EventTrigger self,
            IList<Microsoft.Maui.Controls.TriggerAction> actions)
        {
            foreach (var item in actions)
                self.Actions.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.EventTrigger Actions(this Microsoft.Maui.Controls.EventTrigger self,
            params Microsoft.Maui.Controls.TriggerAction[] actions)
        {
            foreach (var item in actions)
                self.Actions.Add(item);
            return self;
        }
        
        public static Microsoft.Maui.Controls.EventTrigger Event(this Microsoft.Maui.Controls.EventTrigger self,
            string @event)
        {
            self.Event = @event;
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
