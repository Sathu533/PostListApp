namespace PostListApp;

public partial class PostListPage : ContentPage
{
    public List<Root> RootList;
    public PostListPage()
    {
        // Initialize page content
        InitializeComponent();
        RootList = new List<Root>();
        GetPostList();
    }

    private async Task GetPostList()
    {
        ApiService apiService = new ApiService();
        var posts = await apiService.GetPosts();
        foreach (var post in posts)
        {
            RootList.Add(post);
        }
        CvPosts.ItemsSource = RootList;
    }
}