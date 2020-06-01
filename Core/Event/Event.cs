using System;
using System.Collections.Generic;

namespace Bagman.Core
{
    // Events are the core of the Bagman app.
    // An AAEvent is an event on AA. Participants submit work in a number of fixed stages,
    // and this manages all of the related data.
    public class AAEvent
    {
        // Event name
        public string Title;

        // Short description in Discord Markdown
        public string ShortDesc;

        // Long description in Discord Markdown
        public string LongDesc;

        // Rules of the event
        public List<string> Rules;

        public List<Participant> Participants;

        // List of stages of the event
        public List<Stage> Stages;
    }
}