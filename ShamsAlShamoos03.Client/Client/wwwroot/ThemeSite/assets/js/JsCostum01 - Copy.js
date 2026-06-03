 
// document.addEventListener("DOMContentLoaded", function () {
//     var marqueeContent = document.querySelector(".marquee-content");
//     var marqueeContainer = document.querySelector(".marquee-container");

//     if (marqueeContent && marqueeContainer) {
//         var textWidth = marqueeContent.scrollWidth; // گرفتن عرض متن کامل
//         var containerWidth = marqueeContainer.clientWidth; // عرض کانتینر

//         var speed = Math.max(20, textWidth / 20); // تعیین مدت‌زمان بر اساس عرض متن
//         marqueeContent.style.animation = `marquee-scroll ${speed}s linear infinite`;
//     }
// });
 
// document.addEventListener("DOMContentLoaded", function () {
//     var marqueeContent = document.querySelector(".marquee-content");
//     var marqueeContainer = document.querySelector(".marquee-container");

//     if (marqueeContent && marqueeContainer) {
//         var textWidth = marqueeContent.scrollWidth; // گرفتن عرض متن کامل
//         var containerWidth = marqueeContainer.clientWidth; // عرض کانتینر

//         // تعیین مدت‌زمان بر اساس طول متن، با حداقل و حداکثر سرعت مناسب
//         var speed = Math.max(10, textWidth / 50); // مقدار کمتر باعث سریع‌تر آمدن متن می‌شود

//         marqueeContent.style.animation = `marquee-scroll ${speed}s linear infinite`;

//         // اضافه کردن افکتی برای شروع سریع‌تر
//         marqueeContent.style.transform = "translateX(100%)";
//         setTimeout(() => {
//             marqueeContent.style.transition = "transform 1s ease-out";
//             marqueeContent.style.transform = "translateX(0)";
//         }, 0); // بعد از ۲۰۰ میلی‌ثانیه شروع کند
//     }
// });


 
    // document.addEventListener("DOMContentLoaded", function () {
    //     var marqueeContent = document.querySelector(".marquee-content");
    //     var marqueeContainer = document.querySelector(".marquee-container");

    //     if (marqueeContent && marqueeContainer) {
    //         var textWidth = marqueeContent.scrollWidth; // عرض کل متن تبلیغات
    //         var containerWidth = marqueeContainer.clientWidth; // عرض کانتینر

    //         // تنظیم حداقل و حداکثر مدت زمان حرکت (عدد کمتر = شروع سریع‌تر)
    //         var speed = Math.max(15, textWidth / 40);

    //         // اضافه کردن یک نسخه‌ی تکراری از متن برای حرکت بدون توقف
    //         var duplicateContent = marqueeContent.cloneNode(true);
    //         marqueeContainer.appendChild(duplicateContent);

    //         // اعمال تنظیمات انیمیشن
    //         marqueeContainer.style.display = "flex";
    //         marqueeContent.style.animation = `marquee-scroll ${speed}s linear infinite`;
    //         duplicateContent.style.animation = `marquee-scroll ${speed}s linear infinite`;

    //         // اطمینان از شروع فوری تبلیغ
    //         marqueeContent.style.transform = "translateX(0)";
    //         duplicateContent.style.transform = "translateX(0)";
    //     }
    // });
 
 
    // document.addEventListener("DOMContentLoaded", function () {
    //     var marqueeContent = document.querySelector(".marquee-content");
    //     var marqueeContainer = document.querySelector(".marquee-container");

    //     if (marqueeContent && marqueeContainer) {
    //         var textWidth = marqueeContent.scrollWidth; // عرض کل متن تبلیغات
    //         var containerWidth = marqueeContainer.clientWidth; // عرض کانتینر

    //         // تعیین سرعت متناسب با طول متن
    //         var speed = Math.max(15, textWidth / 50); 

    //         // اضافه کردن یک نسخه‌ی تکراری از متن برای حرکت بی‌وقفه
    //         var duplicateContent = marqueeContent.cloneNode(true);
    //         marqueeContainer.appendChild(duplicateContent);

    //         // تنظیم مقدار اولیه برای جلوگیری از تأخیر
    //         marqueeContent.style.transform = "translateX(0)";
    //         duplicateContent.style.transform = "translateX(0)";

    //         // اطمینان از اجرای فوری انیمیشن
    //         setTimeout(() => {
    //             marqueeContent.style.animation = `marquee-scroll ${speed}s linear infinite`;
    //             duplicateContent.style.animation = `marquee-scroll ${speed}s linear infinite`;
    //         }, 50); // تأخیر ۵۰ میلی‌ثانیه برای اطمینان از پردازش اولیه
    //     }
    // });
 


 
    // document.addEventListener("DOMContentLoaded", function () {
    //     var marqueeContainer = document.querySelector(".marquee-container");
    //     var marqueeContent = document.querySelector(".marquee-content");

    //     if (marqueeContent && marqueeContainer) {
    //         var textWidth = marqueeContent.scrollWidth; // عرض کل متن

    //         // ایجاد یک کپی برای نمایش پیوسته
    //         var duplicateContent = marqueeContent.cloneNode(true);
    //         marqueeContainer.appendChild(duplicateContent);

    //         // تنظیم انیمیشن با سرعت متناسب
    //         var speed = Math.max(10, textWidth / 50); 

    //         marqueeContainer.style.display = "flex"; // نمایش کنار هم دو نسخه متن
    //         marqueeContainer.style.width = `${textWidth * 2}px`; // دو برابر عرض متن
    //         marqueeContent.style.animation = `marquee-scroll ${speed}s linear infinite`;
    //         duplicateContent.style.animation = `marquee-scroll ${speed}s linear infinite`;

    //         // موقعیت اولیه نسخه دوم
    //         duplicateContent.style.position = "absolute";
    //         duplicateContent.style.left = `${textWidth}px`;
    //     }
    // });
  
    // document.addEventListener("DOMContentLoaded", function () {
    //     var marqueeContainer = document.querySelector(".marquee-container");
    //     var marqueeContent = document.querySelector(".marquee-content");

    //     if (marqueeContent && marqueeContainer) {
    //         var textWidth = marqueeContent.scrollWidth; // عرض متن

    //         // ایجاد نسخه‌ی تکراری کنار متن اصلی
    //         var duplicateContent = marqueeContent.cloneNode(true);
    //         marqueeContainer.appendChild(duplicateContent);

    //         // محاسبه سرعت حرکت بر اساس طول متن
    //         var speed = Math.max(10, textWidth / 50); 

    //         // استایل لازم برای نمایش پیوسته
    //         marqueeContainer.style.display = "flex";
    //         marqueeContainer.style.width = `${textWidth * 2}px`; // دو برابر عرض متن

    //         // تنظیم انیمیشن
    //         marqueeContainer.style.animation = `marquee-scroll ${speed}s linear infinite`;
    //     }
    // });
 
    document.addEventListener("DOMContentLoaded", function () {
        var marqueeContainer = document.querySelector(".marquee-container");
        var marqueeContent = document.querySelector(".marquee-content");

        if (marqueeContent && marqueeContainer) {
            var textWidth = marqueeContent.scrollWidth; // عرض متن

            // ایجاد نسخه‌ی تکراری برای حرکت پیوسته
            var duplicateContent = marqueeContent.cloneNode(true);
            marqueeContainer.appendChild(duplicateContent);

            // تنظیم انیمیشن با سرعت متناسب با طول متن
            var speed = Math.max(10, textWidth / 50); 

            // نمایش پیوسته و بدون مکث
            marqueeContainer.style.display = "flex";
            marqueeContainer.style.width = `${textWidth * 2}px`; // دو برابر عرض متن

            // اجرای انیمیشن از **راست به چپ**
            marqueeContainer.style.animation = `marquee-scroll ${speed}s linear infinite`;
        }
    });
 

