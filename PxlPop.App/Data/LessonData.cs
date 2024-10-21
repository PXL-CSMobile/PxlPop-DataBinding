using PxlPop.App.Models;

namespace PxlPop.App.Data
{
    public static class LessonData
    {
        public static async Task<List<Lesson>> GenerateLessonsAsync()
        {
            List<Lesson> lessons = new List<Lesson>();

            DateTime fridayStart = new DateTime(2024, 10, 4, 18, 0, 0);
            DateTime saturdayStart = new DateTime(2024, 10, 5, 14, 0, 0);
            DateTime sundayStart = new DateTime(2024, 10, 6, 14, 0, 0);

            TimeSpan lessonDuration = TimeSpan.FromMinutes(60);

            // Helper function to schedule lessons for a department
            async void AddDepartmentLessons(string department, DateTime dayStart, string[] topics, string[] lecturers)
            {
                DateTime currentTime = dayStart;

                foreach (string topic in topics)
                {
                    lessons.Add(new Lesson
                    {
                        Name = topic,
                        Description = $"A detailed exploration of {topic} within the {department} field.",
                        Lecturers = string.Join(", ", lecturers),
                        Begin = currentTime,
                        Duration = lessonDuration,
                        Department = department
                    });

                    currentTime = currentTime.Add(lessonDuration);
                    await Task.Delay(20);
                }
            }

            // Business Department
            string[] businessTopics = {
            "Financial Planning", "Marketing Strategies", "Supply Chain Management", "Business Ethics",
            "Corporate Governance", "Entrepreneurship", "Leadership and Management", "Global Business",
            "Business Intelligence", "Risk Management"
        };
            string[] businessLecturers = { "Dr. Emily Davis", "Mr. Alan Moore", "Prof. Sarah Nguyen" };

            AddDepartmentLessons("Business", fridayStart, businessTopics, businessLecturers);
            AddDepartmentLessons("Business", saturdayStart, businessTopics, businessLecturers);
            AddDepartmentLessons("Business", sundayStart, businessTopics, businessLecturers);

            // Education Department
            string[] educationTopics = {
            "Innovative Teaching Methods", "Curriculum Design", "Assessment Strategies", "Inclusive Education",
            "Teacher Training", "Blended Learning", "Student Engagement", "Online Learning Platforms",
            "Education Policy", "Classroom Management"
        };
            string[] educationLecturers = { "Prof. Anna Smith", "Ms. Claire Bennett", "Dr. Fiona Harper" };

            AddDepartmentLessons("Education", fridayStart, educationTopics, educationLecturers);
            AddDepartmentLessons("Education", saturdayStart, educationTopics, educationLecturers);
            AddDepartmentLessons("Education", sundayStart, educationTopics, educationLecturers);

            // Healthcare Department
            string[] healthcareTopics = {
            "Telemedicine and AI", "Mental Health in Digital Age", "Public Health Policy", "Preventative Healthcare",
            "Patient Data Security", "Healthcare Robotics", "Nutrition and Wellness", "Medical Ethics",
            "Genomics and Precision Medicine", "Telemedicine: The Future"
        };
            string[] healthcareLecturers = { "Dr. Rachel Stewart", "Prof. Daniel O'Brien", "Dr. Oliver Brown" };

            AddDepartmentLessons("Healthcare", fridayStart, healthcareTopics, healthcareLecturers);
            AddDepartmentLessons("Healthcare", saturdayStart, healthcareTopics, healthcareLecturers);
            AddDepartmentLessons("Healthcare", sundayStart, healthcareTopics, healthcareLecturers);

            // Digital Department
            string[] digitalTopics = {
            "AI and Machine Learning", "Cybersecurity Essentials", "Blockchain Applications", "Big Data Analytics",
            "Cloud Computing", "Internet of Things (IoT)", "Software Development Trends", "UX/UI Design",
            "Mobile App Development", "AR/VR in Business"
        };
            string[] digitalLecturers = { "Krista Smeets", "Piet Seurs", "Bob Dekkers" };

            AddDepartmentLessons("Digital", fridayStart, digitalTopics, digitalLecturers);
            AddDepartmentLessons("Digital", saturdayStart, digitalTopics, digitalLecturers);
            AddDepartmentLessons("Digital", sundayStart, digitalTopics, digitalLecturers);

            // Media & Tourism Department
            string[] mediaTourismTopics = {
            "Sustainable Tourism", "Social Media Marketing", "Content Creation", "Public Relations Strategies",
            "Influencer Marketing", "Event Management", "Digital Marketing Analytics", "Virtual Tourism",
            "Brand Management", "Travel Blogging"
        };
            string[] mediaTourismLecturers = { "Dr. Lucas Taylor", "Ms. Elena Russo", "Mr. Michael Ford" };

            AddDepartmentLessons("Media & Tourism", fridayStart, mediaTourismTopics, mediaTourismLecturers);
            AddDepartmentLessons("Media & Tourism", saturdayStart, mediaTourismTopics, mediaTourismLecturers);
            AddDepartmentLessons("Media & Tourism", sundayStart, mediaTourismTopics, mediaTourismLecturers);

            // People & Society Department
            string[] peopleSocietyTopics = {
            "Social Media and Society", "Cultural Diversity", "Human Rights Advocacy", "Gender Equality",
            "Youth Empowerment", "Public Policy", "Mental Health Awareness", "Community Development",
            "Social Activism", "Environmental Justice"
        };
            string[] peopleSocietyLecturers = { "Dr. David Black", "Ms. Sarah Lopez", "Mr. John Kim" };

            AddDepartmentLessons("People & Society", fridayStart, peopleSocietyTopics, peopleSocietyLecturers);
            AddDepartmentLessons("People & Society", saturdayStart, peopleSocietyTopics, peopleSocietyLecturers);
            AddDepartmentLessons("People & Society", sundayStart, peopleSocietyTopics, peopleSocietyLecturers);

            // Green & Tech Department
            string[] greenTechTopics = {
            "Renewable Energy", "Electric Vehicles", "Sustainable Architecture", "Green Supply Chains",
            "Carbon Footprint Reduction", "Circular Economy", "Waste Management Solutions", "Water Conservation",
            "Solar Energy Systems", "Sustainable Agriculture"
        };
            string[] greenTechLecturers = { "Prof. Andrew Green", "Ms. Jessica White", "Dr. Mark Spencer" };

            AddDepartmentLessons("Green & Tech", fridayStart, greenTechTopics, greenTechLecturers);
            AddDepartmentLessons("Green & Tech", saturdayStart, greenTechTopics, greenTechLecturers);
            AddDepartmentLessons("Green & Tech", sundayStart, greenTechTopics, greenTechLecturers);

            // Music Department
            string[] musicTopics = {
            "Digital Music Production", "Classical Composition", "Jazz Improvisation", "Music Theory Fundamentals",
            "Sound Engineering", "Live Performance Techniques", "Songwriting Basics", "Music and Technology",
            "The Future of Music", "Global Music Trends"
        };
            string[] musicLecturers = { "Luc Rerren", "Monique Rutten", "Annelies Van Grunsven" };

            AddDepartmentLessons("Music", fridayStart, musicTopics, musicLecturers);
            AddDepartmentLessons("Music", saturdayStart, musicTopics, musicLecturers);
            AddDepartmentLessons("Music", sundayStart, musicTopics, musicLecturers);

            // MAD Department
            string[] madTopics = {
            "Visual Storytelling", "Animation Techniques", "Film Editing Basics", "Interactive Media",
            "Virtual Reality in Art", "3D Modeling and Animation", "Digital Illustration", "Creative Coding",
            "Game Design", "Media Art Installations"
        };
            string[] madLecturers = { "Bart Dobbelaere", "Katleen Vermeiren", "Stijn Dierckx" };

            AddDepartmentLessons("MAD", fridayStart, madTopics, madLecturers);
            AddDepartmentLessons("MAD", saturdayStart, madTopics, madLecturers);
            AddDepartmentLessons("MAD", sundayStart, madTopics, madLecturers);

            return lessons;
        }
    }
}
