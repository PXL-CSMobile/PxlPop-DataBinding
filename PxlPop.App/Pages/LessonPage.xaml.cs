using PxlPop.App.Models;

namespace PxlPop.App.Pages;

[QueryProperty(nameof(Lesson), "Lesson")]
public partial class LessonPage : ContentPage
{
	public LessonPage()
	{
		InitializeComponent();
	}

	private Lesson _lesson;

	public Lesson Lesson
	{
		get => _lesson; 
		set 
		{ 
			_lesson = value; 
			titleLabel.Text = value.Name;
			descriptionLabel.Text = value.Description;
		}
	}

}