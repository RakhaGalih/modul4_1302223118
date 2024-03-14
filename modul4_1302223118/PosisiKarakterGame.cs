using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223118
{
    public class PosisiKarakterGame
    {
        private KarakterState currentState;
        public PosisiKarakterGame()
        {
            currentState = KarakterState.Berdiri;
        }
        
        public Transition[] transisi =
    {
        new Transition(KarakterState.Jongkok, KarakterState.Tengkurap, Action.TombolS),
        new Transition(KarakterState.Jongkok, KarakterState.Berdiri, Action.TombolW),
        new Transition(KarakterState.Berdiri, KarakterState.Jongkok, Action.TombolS),
        new Transition(KarakterState.Berdiri, KarakterState.Terbang, Action.TombolW),
        new Transition(KarakterState.Terbang, KarakterState.Jongkok, Action.TombolX),
        new Transition(KarakterState.Terbang, KarakterState.Berdiri, Action.TombolS),
        new Transition(KarakterState.Tengkurap, KarakterState.Jongkok, Action.TombolW)
    };

        public KarakterState GetNextState(KarakterState stateAwal, Action action)
        {
            KarakterState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.stateAwal && action == perubahan.action)
                {
                }
                stateAkhir = perubahan.stateAkhir;
            }
            return stateAkhir;
        }

        public void DoAction(Action action)
        {
            KarakterState previousState = currentState;
            this.currentState = GetNextState(currentState, action);
            if (previousState == KarakterState.Berdiri || currentState == KarakterState.Terbang)
            {
                Console.WriteLine("Posisi take off");
            } else 
            if (previousState == KarakterState.Terbang || currentState == KarakterState.Jongkok)
            {
                Console.WriteLine("Posisi landing");
            }
        }
    }
    } 


    public enum KarakterState
    {
        Jongkok, Berdiri, Tengkurap, Terbang
    }

    public enum Action
    {
        TombolW, TombolS, TombolX
    }

    public class Transition
    {
        public KarakterState stateAwal;
        public KarakterState stateAkhir;
        public Action action;
        public Transition(KarakterState stateAwal, KarakterState stateAkhir, Action action)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.action = action;
        }
    }
