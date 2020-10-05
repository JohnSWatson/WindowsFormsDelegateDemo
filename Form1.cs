namespace WindowsFormsDelegateDemo
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// This is an example of C# desktop windows application where control properties can be set from child class.
    /// I have done this because:
    /// 1.	The C# gods not believe children should be able to talk to there parents without shouting such that everyone can hear.
    /// 2.	All examples for the use of delegates use console apps, so I took one and converted it.
    /// 3.	I am sick of get all sorts “not accessible” or and “protection level” messages from the C# gods
    /// </summary>
    /// <param name="sender">The sender<see cref="Object"/>.</param>
    /// <param name="e">The e<see cref="ThresholdReachedEventArgs"/>.</param>
    public delegate void ThresholdReachedEventHandler(Object sender, ThresholdReachedEventArgs e);

    /// <summary>
    /// Defines the <see cref="Form1" />.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Defines the totalCount.
        /// </summary>
        Counter totalCount = new Counter();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Subscribe to the Thresholdreached event
            totalCount.ThresholdReached += totalCount_ThresholdReached;
        }

        /// <summary>
        /// Handel the ThresholdReached of totalCount, totalCount_ThresholdReached.
        /// </summary>
        /// <param name="sender">The sender<see cref="Object"/>.</param>
        /// <param name="e">The e<see cref="ThresholdReachedEventArgs"/>.</param>
        private void totalCount_ThresholdReached(Object sender, ThresholdReachedEventArgs e)
        {
            textBoxDid.Text = "The threshold of " + e.Threshold + " was reached at " + e.TimeReached + ".";
        }

        /// <summary>
        /// The buttonDo_Click.
        /// Trigger an event by evoking the Add methode of the Counter Class
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void buttonDo_Click(object sender, EventArgs e)
        {
            totalCount.Add(1);
        }
    }
    //  END public Form1()
    // ===============




    /// <summary>
    /// Defines the <see cref="ThresholdReachedEventArgs" />.
    /// Provides a structure for the Threshold Reached event data
    /// </summary>
    public class ThresholdReachedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the Threshold.
        /// </summary>
        public int Threshold { get; set; }

        /// <summary>
        /// Gets o the TimeReached.  
        /// </summary>
        public DateTime TimeReached { get { return DateTime.Now; }  }
    }
    // END public class ThresholdReachedEventArgs : EventArgs

    /// <summary>
    /// Defines the <see cref="Counter" />.
    /// Counts how many times something is done
    /// </summary>
    class Counter
    {
        /// <summary>
        /// Gets or sets the count of how many times stuff as been done.
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Counter"/> class.
        /// </summary>
        /// <param name="passedThreshold">The passedThreshold<see cref="int"/>.</param>
        public Counter()
        {
            count = 0;   // Yeh I wanted a constructor
        }

        /// <summary>
        /// The Add.
        /// </summary>
        /// <param name="x">The x<see cref="int"/>.</param>
        public void Add(int x)
        {
            count += x;   // Add to the count

            // Create an instance of the ThresholdReachedEventArgs class
            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
            args.Threshold = count;
            // Triger the event
            OnThresholdReached(args);
        }

        /// <summary>
        /// The OnThresholdReached.
        /// </summary>
        /// <param name="e">The e<see cref="ThresholdReachedEventArgs"/>.</param>
        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            ThresholdReachedEventHandler handler = ThresholdReached;
            if (handler != null)   // Check the is someone who listening (subscribed) for this event
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// Defines the ThresholdReached event handler.
        /// </summary>
        public event ThresholdReachedEventHandler ThresholdReached;
    }
}
