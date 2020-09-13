using System.Collections.ObjectModel;

namespace ECourse_UI.ViewModels
{
    class CardsViewModel
    {
        ObservableCollection<CardsModel> _courses { get; set; }

        public ObservableCollection<CardsModel> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public CardsViewModel()
        {
            _courses = new ObservableCollection<CardsModel>()
            {
                new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/1.jpg",
                    TutorImagePath="/assets/p1.png"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/2.jpg",
                    TutorImagePath="/assets/p2.jpg"
                },
                 new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/3.jpg",
                    TutorImagePath="/assets/p3.jpg"
                },
                 new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/3.jpg",
                    TutorImagePath="/assets/p3.jpg"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/4.jpg",
                    TutorImagePath="/assets/p4.jpg"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/2.jpg",
                    TutorImagePath="/assets/p5.jpg"
                },
                new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/1.jpg",
                    TutorImagePath="/assets/p5.jpg"
                },
                new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/2.jpg",
                    TutorImagePath="/assets/p4.png"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/2.jpg",
                    TutorImagePath="/assets/p3.jpg"
                },
                 new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/3.jpg",
                    TutorImagePath="/assets/p2.jpg"
                },
                 new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/3.jpg",
                    TutorImagePath="/assets/p3.jpg"
                },
                 new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/3.jpg",
                    TutorImagePath="/assets/p3.jpg"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/4.jpg",
                    TutorImagePath="/assets/p4.jpg"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/4.jpg",
                    TutorImagePath="/assets/p4.jpg"
                },
                new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/1.jpg",
                    TutorImagePath="/assets/p5.jpg"
                },
                new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/1.jpg",
                    TutorImagePath="/assets/p1.png"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/4.jpg",
                    TutorImagePath="/assets/p4.jpg"
                },
                new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/1.jpg",
                    TutorImagePath="/assets/p5.jpg"
                },new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/1.jpg",
                    TutorImagePath="/assets/p1.png"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/2.jpg",
                    TutorImagePath="/assets/p2.jpg"
                },
                 new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/3.jpg",
                    TutorImagePath="/assets/p3.jpg"
                },
                new CardsModel(){
                    CourseName="Photography",
                    Lessons="12 lessons",
                    CourseDuration="1h 30min",
                    ImagePath="/assets/4.jpg",
                    TutorImagePath="/assets/p4.jpg"
                },
                new CardsModel(){
                    CourseName="UI/UX Design",
                    Lessons="20 lessons",
                    CourseDuration="2h 30min",
                    ImagePath="/assets/1.jpg",
                    TutorImagePath="/assets/p5.jpg"
                }
            };
        }
    }
}