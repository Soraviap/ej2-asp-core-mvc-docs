public ActionResult ShowLabel()
{
    ViewBag.textStyle = new
    {
        size = "15px",
        fontWeight = "500",
        fontStyle = "Normal",
        fontFamily = "Segoe UI"
    };
    string[] yLabels = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    ViewBag.yLabels = yLabels;
    ViewBag.border = new { color = "white" };
    ViewBag.dataSource = GetDataSource();
    return View();
}

 private int[,] GetDataSource()
 {
     int?[,] dataSource = new int?[,]
            {
                { null, null, null, null, 16, 48, 0 },
                {0, 15, 0, 24, 0, 39, 0},
                { 0, 18, 37, 0, 0, 50, 0},
                { 0, 10, 0, 0, 44, 5, 0},
                { 0, 36, 0, 45, 20, 18, 0},
                { 0, 28, 1, 42, 0, 10, 0},
                { 0, 16, 32, 0, 1, 25, 0},
                { 0, 31, 2, 9, 24, 0, 0},
                { 0, 8, 47, 0, 0, 35, 0},
                { 0, 31, 0, 0, 0, 40, 0},
                { 0, 8, 0, 27, 0, 35, 0},
                {0, 12, 9, 45, 0, 8, 0},
                {0, 0, 13, 0, 22, 10, 0},
                {0, 16, 32, 0, 1, 25, 0},
                {0, 31, 2, 9, 24, 0, 0},
                {0, 8, 47, 27, 0, 35, 0},
                {0, 28, 14, 10, 0, 0, 0},
                {0, 36, 0, 45, 20, 18, 0},
                {0, 28, 1, 42, 0, 10, 0},
                {0, 31, 0, 24, 0, 40, 0},
                {0, 8, 47, 27, 0, 35, 0},
                {0, 36, 0, 45, 20, 18, 0},
                {0, 28, 1, 42, 0, 10, 0},
                {0, 31, 0, 24, 0, 40, 0},
                {0, 16, 32, 0, 1, 25, 0},
                {0, 31, 2, 9, 24, 0, 0},
                {0, 8, 47, 27, 0, 35, 0},
                {0, 10, 0, 36, 23, 19, 0},
                {0, 18, 37, 23, 0, 50, 0},
                {0, 28, 14, 10, 0, 0, 0},
                {0, 18, 37, 23, 0, 50, 0},
                {0, 18, 37, 23, 0, 50, 0},
                {0, 28, 14, 10, 0, 0, 0},
                {0, 31, 2, 9, 24, 0, 0},
                {0, 8, 47, 27, 0, 35, 0},
                {0, 10, 2, 0, 44, 5, 0},
                {0, 36, 0, 45, 20, 18, 0},
                {0, 28, 1, 42, 0, 10, 0},
                {0, 31, 0, 24, 0, 40, 1},
                {0, 16, 32, 0, 1, 25, 0},
                {0, 31, 2, 9, 24, 0, 0},
                {0, 8, 47, 27, 0, 35, 0},
                {0, 10, 2, 0, 44, 5, 0},
                {0, 12, 9, 45, 0, 8, 0},
                {0, 0, 13, 35, 22, 10, 0},
                {0, 28, 14, 10, 0, 0, 0},
                {0, 36, 0, 45, 20, 18, 2},
                {0, 28, 1, 42, 0, 10, 0},
                {0, 31, 0, 24, 0, 40, 1},
                {0, 8, 47, 27, 0, 35, 0},
                {0, 10, 2, 0, 44, 5, 0},
                {0, 31, 2, 9, 24, 0, 1},
                {0, 8, 47, 27, 0, 35, 40},
                {0, 10, 2, 0, 44, 5, null},
            };
            return data;
 }