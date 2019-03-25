using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;
using AbstractWagFactory;
using Builder;
using Decorator;
using Iterator;
using Base;

namespace WAGFactory
{
    public partial class Program : Form
    {
        private PictureBox pictureBox1;

        public Program()
        {

            InitializeComponent();
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
            //AbstractWagDemo();
            //BuilderPatternDemo();
            //SmallWidget();
            //MediumWidget();
            //DecoratorPatternDemo();
            IteratorDemo();
            //SizeSelectDemo();
        }

        private static void SizeSelectDemo()
        {
            AbstractWAGFactory factory = new WidgetFactory();
            IWidgetComponents widgetComponents = factory.CreateWidgetComponents();
            ICreateSize create = factory.CreatSize();
            AbstractWAGFactory gFactory = new GadgetFactory();
            IGadgetComponents gadgetComponents = gFactory.CreateGadgetComponents();
            ICreateSize createSize = gFactory.CreatSize();



            Console.WriteLine("Welcome to our Factory. We are in the business of : ");
            Console.WriteLine(" ");
            Console.WriteLine(create.SmallWidget);
            Console.WriteLine(create.MediumWidget);
            Console.WriteLine(create.LargeWidget);
            Console.WriteLine(create.SmallGadget);
            Console.WriteLine(create.MediumGadget);
            Console.WriteLine(create.LargeGadget);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Below is a list of our Products: ");
            Console.WriteLine(" ");
            IteratorDemo();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            SelectWagSize sws = new SelectWagSize();
            sws.WagSelection();
            Console.WriteLine(" ");
            Console.ReadLine();
        }

        private static void IteratorDemo()
        {
            Console.WriteLine("=== Widgets ===");
            Console.WriteLine(" ");
            WidgetRange widgetRange = new WidgetRange();
            PrintIterator(widgetRange.GetEnumerator());
            Console.WriteLine(" ");
            Console.WriteLine("===============================================================");
            Console.WriteLine(" ");
            Console.WriteLine("=== Gadgets ===");
            Console.WriteLine(" ");
            GadgetRange gadgetRange = new GadgetRange();
            PrintIterator(gadgetRange.GetEnumerator());
            Console.WriteLine(" ");
        }

        public static void PrintIterator(IEnumerator<IWag> iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

        private static void DecoratorPatternDemo()
        {
            IWag mySmallWidget = new SmallWidget(FinishColor.PlainBlack);
            Console.WriteLine(mySmallWidget);

            mySmallWidget = new CustomComponentsOption(mySmallWidget);
            Console.WriteLine(mySmallWidget);

            mySmallWidget = new EverythingGoldOption(mySmallWidget);
            Console.WriteLine(mySmallWidget);

        }

        private static void MediumWidget()
        {
            AbstractWidget widget = new MediumWidget(FinishColor.PaintedGreen);
            WagBuilder builder = new WidgetBuilder(widget);
            WagDirector director = new WidgetDirector();
            IWag mediumWidget = director.Build(builder);
            Console.WriteLine(mediumWidget);
        }

        private static void SmallWidget()
        {
            AbstractWidget widget = new SmallWidget();
            WagBuilder builder = new WidgetBuilder(widget);
            WagDirector director = new WidgetDirector();
            IWag smallWidget = director.Build(builder);
            Console.WriteLine(smallWidget);
        }

        private static void BuilderPatternDemo()
        {
            AbstractWidget abstractWidget = new SmallWidget(FinishColor.PlatedPlatinum);
            WagBuilder wagBuilder = new WidgetBuilder(abstractWidget);
            WagDirector wagDirector = new WidgetDirector();
            IWag widget = wagDirector.Build(wagBuilder);
            Console.WriteLine(widget);

            AbstractGadget abstractGadget = new SmallGadget(FinishColor.PlainBlack);
            WagBuilder builder = new GadgetBuilder(abstractGadget);
            WagDirector director = new GadgetDirector();
            IWag gadget = director.Build(builder);
            Console.WriteLine(gadget);
        }

        private static void AbstractWagDemo()
        {
            AbstractWAGFactory factory = new WidgetFactory();
            IWidgetComponents widgetComponents = factory.CreateWidgetComponents();
            ICreateSize create = factory.CreatSize();
            Console.WriteLine(widgetComponents.GearParts);
            Console.WriteLine(widgetComponents.SpringParts);
            Console.WriteLine(widgetComponents.LeverParts);
            Console.WriteLine(create.SmallWidget);
            Console.WriteLine(create.MediumWidget);
            Console.WriteLine(create.LargeWidget);



            AbstractWAGFactory gFactory = new GadgetFactory();
            IGadgetComponents gadgetComponents = gFactory.CreateGadgetComponents();
            ICreateSize createSize = gFactory.CreatSize();
            Console.WriteLine(gadgetComponents.Buttons);
            Console.WriteLine(gadgetComponents.Lights);
            Console.WriteLine(gadgetComponents.Switch);
            Console.WriteLine(gadgetComponents.Widgets);
            Console.WriteLine(createSize.SmallGadget);
            Console.WriteLine(createSize.MediumGadget);
            Console.WriteLine(createSize.LargeGadget);

        }
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WAGFactory.Properties.Resources.wag2_sv;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(267, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Program
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(912, 700);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Program";
            this.Text = "WAG CORPORATION INC.";
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
