using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Course
    {
        // Định danh duy nhất cho khóa học
        public int Id { get; set; }

        // Tiêu đề của khóa học
        public string Title { get; set; }

        // Slug (phiên bản thân thiện của URL cho tiêu đề) dùng để tạo đường dẫn trực quan
        public string Slug { get; set; }

        // Mô tả ngắn gọn về khóa học
        public string Description { get; set; }

        // URL đến hình ảnh đại diện cho khóa học
        public string ImageUrl { get; set; }

        // URL đến icon của khóa học
        public string IconUrl { get; set; }

        // Giá hiện tại của khóa học
        public decimal Price { get; set; }

        // Giá gốc của khóa học trước khi giảm giá (nếu có)
        public decimal OldPrice { get; set; }

        // Đánh dấu liệu khóa học có phải là nội dung cao cấp (Pro) hay không
        public bool IsPro { get; set; }

        // Trạng thái công khai của khóa học, xác định liệu nó có được xuất bản hay không
        public bool IsPublished { get; set; }

        // Số lượng học viên đã đăng ký khóa học
        public int StudentsCount { get; set; }

        // Tổng số video có trong khóa học
        public int VideosCount { get; set; }

        // Tổng thời gian của tất cả các video trong khóa học, tính bằng giây
        public int Duration { get; set; }

        // Chuỗi văn bản biểu diễn tổng thời gian của khóa học
        public string DurationText { get; set; }

        // Tiến trình học tập của người dùng hiện tại, biểu diễn dưới dạng phần trăm
        public double UserProgress { get; set; }

        // Thời gian hoàn thành phần cuối cùng của khóa học bởi người dùng, có thể là null nếu chưa hoàn thành
        public DateTime? LastCompletedAt { get; set; }

        // Ngày khóa học được công bố chính thức
        public DateTime PublishedAt { get; set; }
    }
}