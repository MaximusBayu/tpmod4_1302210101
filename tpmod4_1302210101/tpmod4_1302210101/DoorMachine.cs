using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302210101
{
    internal class DoorMachine
    {
        public enum State
        {
            Terkunci,
            Terbuka
        }

        public enum Trigger
        {
            BukaPintu,
            KunciPintu
        }

        class transition {
            public State prevState;
            public State nextState;
            public Trigger trigger;

            public transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transition[] trans = {
            new transition(State.Terkunci, State.Terbuka, Trigger.BukaPintu),
            new transition(State.Terbuka, State.Terbuka, Trigger.BukaPintu),
            new transition(State.Terbuka, State.Terkunci, Trigger.KunciPintu),
            new transition(State.Terkunci, State.Terkunci, Trigger.KunciPintu),
        };

        public State current;
        public State getNextState(State prevState, Trigger trigger) {
            State nextState = prevState;

            for (int i = 0; i < trans.Length; i++) {
                if (trans[i].prevState == prevState && trans[i].trigger == trigger)
                    nextState = trans[i].nextState;
            }
            return nextState;
        }

        public void actTrigger(Trigger trigger)
        {
            State nextState = getNextState(current, trigger);
            current = nextState;
        }

    }
}
