using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard_project.Views.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserMapControl.xaml
    /// </summary>
    public partial class UserMapControl : UserControl
    {
        Model3D model1;
        Model3D model1Dark;

        Model3D model2;
        Model3D model2Dark;

        Model3D model3;
        Model3D model3Dark;

        Model3D model4;

        Model3D model5;
        
        Model3D model6;
        
        Model3D model7;
        
        Model3D model8;
        
        Model3D model9;
        
        Model3D model10;

        string headerdef = "ПАО \"Татнефть\"";
        public UserMapControl()
        {
            InitializeComponent();

            NameNGDY.Text = headerdef;

            ModelImporter importer = new ModelImporter();

            //камера
            OrthographicCamera camera = new OrthographicCamera();
            camera.Position = new Point3D(0, 2, 5);
            camera.LookDirection = new Vector3D(0, -2, -5);
            camera.Width = 1.5;
            ViewPortMap.Camera = camera;

            //Анимация моделей
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 0.01;
            animation.AutoReverse = true;
            animation.Duration = TimeSpan.FromSeconds(1);
            animation.RepeatBehavior = RepeatBehavior.Forever;

            //Функции
            void UI_MouseEnter(ModelUIElement3D modelUIElement, ModelUIElement3D modelUIElementDark)
            {
                ViewPortMap.Children.Remove(modelUIElement);
                ViewPortMap.Children.Add(modelUIElementDark);
                modelUIElementDark.Transform.BeginAnimation(TranslateTransform3D.OffsetYProperty, animation);
            };

            void UI_MouseLeave(ModelUIElement3D modelUIElement, ModelUIElement3D modelUIElementDark)
            {
                ViewPortMap.Children.Remove(modelUIElementDark);
                ViewPortMap.Children.Add(modelUIElement);
            };

            bool[] isFunctionEnabled = { true, true, true, true, true, true, true, true, true, true };

            // Добавление моделей

            //Альметьевск
            model1 = importer.Load("./Resources/Map3D/Light/almet.obj");
            ModelUIElement3D UImodel1 = new ModelUIElement3D();
            UImodel1.Model = model1;
            ViewPortMap.Children.Add(UImodel1);
            //АльметьевскDark
            model1Dark = importer.Load("./Resources/Map3D/Dark/almetDark.obj");
            ModelUIElement3D UImodel1Dark = new ModelUIElement3D();
            UImodel1Dark.Model = model1Dark;
            UImodel1Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s1 = "НГДУ АльметНефть";

            

            UImodel1.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel1, UImodel1Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s1;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s1;
                }
            };

            UImodel1Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[0] == true)
                {
                    UI_MouseLeave(UImodel1, UImodel1Dark);
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel1Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[0])
                {
                    case true:
                        isFunctionEnabled[0] = !isFunctionEnabled[0];
                        break;
                    case false:
                        isFunctionEnabled[0] = !isFunctionEnabled[0];
                        break;
                }
            };

            //Азнакаево
            model2 = importer.Load("./Resources/Map3D/Light//aznakaev.obj");
            ModelUIElement3D UImodel2 = new ModelUIElement3D();
            UImodel2.Model = model2;
            ViewPortMap.Children.Add(UImodel2);
            //АзнакаевоDark
            model2Dark = importer.Load("./Resources/Map3D/Dark/aznakaevDark.obj");
            ModelUIElement3D UImodel2Dark = new ModelUIElement3D();
            UImodel2Dark.Model = model2Dark;
            UImodel2Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s2 = "НГДУ АзнакаевНефть";

            UImodel2.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel2, UImodel2Dark);
                if (NameNGDY.Text == "ПАО \"ТатНефть\"")
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s2;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s2;
                }
            };

            UImodel2Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[1] == true)
                {
                    UI_MouseLeave(UImodel2, UImodel2Dark);
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel2Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[1])
                {
                    case true:
                        isFunctionEnabled[1] = !isFunctionEnabled[1];
                        break;
                    case false:
                        isFunctionEnabled[1] = !isFunctionEnabled[1];
                        break;
                }
            };

            //Бавлы
            model3 = importer.Load("./Resources/Map3D/Light/bavlinsk.obj");
            ModelUIElement3D UImodel3 = new ModelUIElement3D();
            UImodel3.Model = model3;
            ViewPortMap.Children.Add(UImodel3);
            //БавлыDark
            model3Dark = importer.Load("./Resources/Map3D/Dark/bavlinskDark.obj");
            ModelUIElement3D UImodel3Dark = new ModelUIElement3D();
            UImodel3Dark.Model = model3Dark;
            UImodel3Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s3 = "НГДУ БавлыНефть";

            UImodel3.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel3, UImodel3Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s3;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s3;
                }
            };

            UImodel3Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[2] == true)
                {
                    UI_MouseLeave(UImodel3, UImodel3Dark);
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel3Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[2])
                {
                    case true:
                        isFunctionEnabled[2] = !isFunctionEnabled[2];
                        break;
                    case false:
                        isFunctionEnabled[2] = !isFunctionEnabled[2];
                        break;
                }
            };

            //Джалиль
            model4 = importer.Load("./Resources/Map3D/Light/djalil.obj");
            ModelUIElement3D UImodel4 = new ModelUIElement3D();
            UImodel4.Model = model4;
            ViewPortMap.Children.Add(UImodel4);

            Model3D model4dark = importer.Load("./Resources/Map3D/Dark/djalilDark.obj");
            ModelUIElement3D UImodel4Dark = new ModelUIElement3D();
            UImodel4Dark.Model = model4dark;
            UImodel4Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s4 = "НГДУ Джалильнефть";

            UImodel4.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel4, UImodel4Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s4;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s4;
                }
            };

            UImodel4Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[3] == true)
                {
                    UI_MouseLeave(UImodel4, UImodel4Dark);
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel4Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[3])
                {
                    case true:
                        isFunctionEnabled[3] = !isFunctionEnabled[3];
                        break;
                    case false:
                        isFunctionEnabled[3] = !isFunctionEnabled[3];
                        break;
                }
            };

            //Елхов
            model5 = importer.Load("./Resources/Map3D/Light/elhov.obj");
            ModelUIElement3D UImodel5 = new ModelUIElement3D();
            UImodel5.Model = model5;
            ViewPortMap.Children.Add(UImodel5);

            Model3D model5dark = importer.Load("./Resources/Map3D/Dark/elhovDark.obj");
            ModelUIElement3D UImodel5Dark = new ModelUIElement3D();
            UImodel5Dark.Model = model5dark;
            UImodel5Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s5 = "НГДУ Елховнефть";

            UImodel5.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel5, UImodel5Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s5;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s5;
                }
            };

            UImodel5Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[4] == true)
                {
                    UI_MouseLeave(UImodel5, UImodel5Dark);
                    BorderHeader.Visibility = Visibility.Hidden;
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel5Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[4])
                {
                    case true:
                        isFunctionEnabled[4] = !isFunctionEnabled[4];
                        break;
                    case false:
                        isFunctionEnabled[4] = !isFunctionEnabled[4];
                        break;
                }
            };

            //Призрак
            model6 = importer.Load("./Resources/Map3D/Light/ghost.obj");
            ModelUIElement3D UImodel6 = new ModelUIElement3D();
            UImodel6.Model = model6;
            ViewPortMap.Children.Add(UImodel6);

            //Лениногорск
            model7 = importer.Load("./Resources/Map3D/Light/lensk.obj");
            ModelUIElement3D UImodel7 = new ModelUIElement3D();
            UImodel7.Model = model7;
            ViewPortMap.Children.Add(UImodel7);

            Model3D model7dark = importer.Load("./Resources/Map3D/Dark/lenskDark.obj");
            ModelUIElement3D UImodel7Dark = new ModelUIElement3D();
            UImodel7Dark.Model = model7dark;
            UImodel7Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s7 = "НГДУ Лениногорскнефть";

            UImodel7.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel7, UImodel7Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s7;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s7;
                }
            };

            UImodel7Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[6] == true)
                {
                    UI_MouseLeave(UImodel7, UImodel7Dark);
                    BorderHeader.Visibility = Visibility.Hidden;
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel7Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[6])
                {
                    case true:
                        isFunctionEnabled[6] = !isFunctionEnabled[6];
                        break;
                    case false:
                        isFunctionEnabled[6] = !isFunctionEnabled[6];
                        break;
                }
            };

            //Нурлат
            model8 = importer.Load("./Resources/Map3D/Light/nurlat.obj");
            ModelUIElement3D UImodel8 = new ModelUIElement3D();
            UImodel8.Model = model8;
            ViewPortMap.Children.Add(UImodel8);

            Model3D model8dark = importer.Load("./Resources/Map3D/Dark/nurlatDark.obj");
            ModelUIElement3D UImodel8Dark = new ModelUIElement3D();
            UImodel8Dark.Model = model8dark;
            UImodel8Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s8 = "НГДУ Нурлатнефть";

            UImodel8.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel8, UImodel8Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s8;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s8;
                }
            };

            UImodel8Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[7] == true)
                {
                    UI_MouseLeave(UImodel8, UImodel8Dark);
                    BorderHeader.Visibility = Visibility.Hidden;
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel7Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[7])
                {
                    case true:
                        isFunctionEnabled[7] = !isFunctionEnabled[7];
                        break;
                    case false:
                        isFunctionEnabled[7] = !isFunctionEnabled[7];
                        break;
                }
            };

            //Прикам
            model9 = importer.Load("./Resources/Map3D/Light/prikam.obj");
            ModelUIElement3D UImodel9 = new ModelUIElement3D();
            UImodel9.Model = model9;
            ViewPortMap.Children.Add(UImodel9);

            Model3D model9dark = importer.Load("./Resources/Map3D/Dark/prikamDark.obj");
            ModelUIElement3D UImodel9Dark = new ModelUIElement3D();
            UImodel9Dark.Model = model9dark;
            UImodel9Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s9 = "НГДУ Прикамнефть";

            UImodel9.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel9, UImodel9Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s9;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s9;
                }
            };

            UImodel9Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[8] == true)
                {
                    UI_MouseLeave(UImodel9, UImodel9Dark);
                    BorderHeader.Visibility = Visibility.Hidden;
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel9Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[8])
                {
                    case true:
                        isFunctionEnabled[8] = !isFunctionEnabled[8];
                        break;
                    case false:
                        isFunctionEnabled[8] = !isFunctionEnabled[8];
                        break;
                }
            };

            //Ямаш
            model10 = importer.Load("./Resources/Map3D/Light/yamash.obj");
            ModelUIElement3D UImodel10 = new ModelUIElement3D();
            UImodel10.Model = model10;
            ViewPortMap.Children.Add(UImodel10);

            Model3D model10dark = importer.Load("./Resources/Map3D/Dark/yamashDark.obj");
            ModelUIElement3D UImodel10Dark = new ModelUIElement3D();
            UImodel10Dark.Model = model10dark;
            UImodel10Dark.Transform = new TranslateTransform3D(0, 0.01, 0);
            string s10 = "НГДУ Ямашнефть";

            UImodel10.MouseEnter += (sender, e) =>
            {
                UI_MouseEnter(UImodel10, UImodel10Dark);
                if (NameNGDY.Text == headerdef)
                {
                    BorderHeader.Visibility = Visibility.Visible;
                    NameNGDY.Text = s10;
                }
                else
                {
                    NameNGDY.Text += "";
                    NameNGDY.Text += " " + s10;
                }
            };

            UImodel10Dark.MouseLeave += (sender, e) =>
            {
                if (isFunctionEnabled[9] == true)
                {
                    UI_MouseLeave(UImodel10, UImodel10Dark);
                    BorderHeader.Visibility = Visibility.Hidden;
                    NameNGDY.Text = headerdef;
                }
            };

            UImodel7Dark.MouseDown += (sender, e) =>
            {
                switch (isFunctionEnabled[9])
                {
                    case true:
                        isFunctionEnabled[9] = !isFunctionEnabled[9];
                        break;
                    case false:
                        isFunctionEnabled[9] = !isFunctionEnabled[9];
                        break;
                }
            };
        }
    }
}
