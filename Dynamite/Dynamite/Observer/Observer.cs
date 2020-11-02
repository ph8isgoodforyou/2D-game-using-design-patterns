using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Observer
{
    public abstract class Subject : GameObject
    {
        private List<ObserverClass> _observers = new List<ObserverClass>();

        public Subject(int x, int y, int totalFrames, int frameWidth, int frameHeight)
            : base(x, y, totalFrames, frameWidth, frameHeight)
        {

        }


        public void Attach(ObserverClass observer)
        {
            _observers.Add(observer);
        }

        public void Detach(ObserverClass observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (ObserverClass o in _observers)
            {
                o.Update();
            }
        }
    }


    //public class ConcreteSubject : Subject

    //{
    //    private string _subjectState;

    //    // Gets or sets subject state

    //    public string SubjectState
    //    {
    //        get { return _subjectState; }
    //        set { _subjectState = value; }
    //    }
    //}


    public abstract class ObserverClass : GameObject

    {
        public ObserverClass(int x, int y, int totalFrames, int frameWidth, int frameHeight, int frameTime) : base(x, y, totalFrames, frameWidth, frameHeight, frameTime)
        {

        }
        public abstract void Update();
    }


    //public class ConcreteObserver : ObserverClass

    //{
    //    private string _name;
    //    private string _observerState;
    //    private ConcreteSubject _subject;

    //    // Constructor

    //    public ConcreteObserver(
    //      ConcreteSubject subject, string name)
    //    {
    //        this._subject = subject;
    //        this._name = name;
    //    }

    //    public override void Update()
    //    {
    //        _observerState = _subject.SubjectState;
    //        Console.WriteLine("Observer {0}'s new state is {1}",
    //          _name, _observerState);
    //    }

    //    // Gets or sets subject

    //    public ConcreteSubject Subject
    //    {
    //        get { return _subject; }
    //        set { _subject = value; }
    //    }
    //}
}
