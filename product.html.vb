<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Products</title>
    <style>
    :root{
        --background-color: #f4f4f4;
        --accent-color: #000000;
        --headline-color: #f4f4f4;
    }
    
    body {
        font-family: 'Poppins', sans-serif;
        margin: 0;
        padding: 0;
    }
    /*-------------------------------navbar-------------------------------*/
    .navbar {
        background-color: var(--background-color);
        color: var(--accent-color);
        padding: 10px 20px;
        display: flex;
        justify-content: space-between;
        align-items: center;
        border-bottom: 2px solid var(--accent-color);
    }
    
    .navbar-content {
        margin-right: 200px;
    }
    
    .logo {
        top: 0;
        display: block;
        margin-top: 10px;
        margin-left: 200px;
        width: 50px;
    }
    
    nav ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        display: flex;
    }
    
    nav ul li {
        margin-left: 20px;
    }
    
    nav ul li a {
        color: var(--accent-color);
        text-decoration: none;
    }
    /*-------------------------------main contents-------------------------------*/
    main {
        max-width: 900px;
        margin: auto;
        padding: 10px;
        background-color: var(--background-color);
        border-radius: 8px; 
    }
    
    h1 {
        font-size: 43px;
        font-weight: 500;
        line-height: 75px;
        text-align: left;
        padding-top: 40px;
        padding-bottom: 30px;
    }
    
    .product-grid {
        width: 100%;
        display: flex;
        gap: 8px;
        justify-content: space-between;
        overflow: hidden;
        align-items: center;
        flex-wrap: wrap;
        padding: 20px;
    }
    
    .product-pict {
        width: 100%;
    }
    
    .product-title {
        font-size: 20px;
        margin: 5px 0;
        font-weight: 600;
    }
    
    .product-price {
        color: gray;
        font-size: 16px;
        font-weight: 500;
    }
    
    .pagination-container {
        width: 100%;
        height: 50vh;
        position: relative;
        background-image: linear-gradient(rgba(0, 0, 0, 0.6), rgba(0, 0, 0, 0.6)) url("#");
        background-size: cover;
        background-position: center;
        display: flex;
        justify-content: center;
        align-items: center;
    }
    
    .pagination-container .page {
        height: 60px;
        position: absolute;
        background:#e6e6e6;
        display: flex;
        align-items: center;
        justify-content: center;
        top: 70%;
        border-radius: 2px;
    
    }
    
    .pagination-container .page li {
        list-style: none;
        display: inline-block;
    }
    
    .pagination-container .page li a {
        position: relative;
        padding: 20px 25px;
        text-decoration: none;
        color: var(--accent-color);
        font-weight: 500;
    }
    
    .pagination-container .page li a:hover,
    .pagination-container .page li.active a {
        background: #999999;
    }
    
    /*-------------------------------footer(msh blm jadi)-------------------------------*/
    .footer {
        text-align: center;
        padding: 20px;
        background-color: var(--accent-color);
        color: var(--background-color);
        position: relative;
        bottom: 0;
        width: 100%;
    }
</style>
</head>

<body>
    <header class="navbar">
        <img src="#" alt="Logo" class="logo">
        <nav class="navbar-content">
            <ul>
                <li><a href="home.html" target="_blank">Home</a></li>
                <li><a href="product.html" target="_blank">Product</a></li>
                <li><a href="howtoorder.html" target="_blank">How to Order</a></li>
                <li><a href="aboutus.html" target="_blank">About Us</a></li>
            </ul>
        </nav>
    </header>

    <main>
        <h1>OUR PRODUCT</h1>
    
    <div class="product-grid">
     <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3">
      <!-- Item 1 -->
      <div class="product-pict">
       <img alt="" height="300" src="#" width="300"/>
       <h2 class="product-title">
        LOREM IPSUM DOLOR SIT AMET
       </h2>
       <p class="product-price">
        Rp.0000000
       </p>
      </div>

      <!-- Item 2 -->
      <div class="product-pict">
       <img alt="" height="300" src="#" width="300"/>
       <h2 class="product-title">
        LOREM IPSUM DOLOR SIT AMET
       </h2>
       <p class="product-price">
        Rp.0000000
       </p>
      </div>

      <!-- Item 3 -->
      <div class="product-pict">
       <img alt="" height="300" src="#" width="300"/>
       <h2 class="product-title">
        LOREM IPSUM DOLOR SIT AMET
       </h2>
       <p class="product-price">
        Rp.0000000
       </p>
      </div>

      <!-- Item 4 -->
      <div class="product-pict">
       <img alt="" height="300" src="#" width="300"/>
       <h2 class="product-title">
        LOREM IPSUM DOLOR SIT AMET
       </h2>
       <p class="product-price">
        Rp.0000000
       </p>
      </div>

      <!-- Item 5 -->
      <div class="product-pict">
       <img alt="" height="300" src="#" width="300"/>
       <h2 class="product-title">
        LOREM IPSUM DOLOR SIT AMET
       </h2>
       <p class="product-price">
        Rp.0000000
       </p>
      </div>

      <!-- Item 6 -->
      <div class="product-pict">
       <img alt="" height="300" src="#" width="300"/>
       <h2 class="product-title">
        LOREM IPSUM DOLOR SIT AMET
       </h2>
       <p class="product-price">
        Rp.0000000
       </p>
      </div>

      <!-- Item 7 -->
      <div class="product-pict">
        <img alt="" height="300" src="#" width="300"/>
        <h2 class="product-title">
         LOREM IPSUM DOLOR SIT AMET
        </h2>
        <p class="product-price">
         Rp.0000000
        </p>
       </div>

      <!-- Item 8 -->
      <div class="product-pict">
        <img alt="" height="300" src="#" width="300"/>
        <h2 class="product-title">
         LOREM IPSUM DOLOR SIT AMET
        </h2>
        <p class="product-price">
         Rp.0000000
        </p>
       </div>

      <!-- Item 9 -->
      <div class="product-pict">
        <img alt="" height="300" src="#" width="300"/>
        <h2 class="product-title">
         LOREM IPSUM DOLOR SIT AMET
        </h2>
        <p class="product-price">
         Rp.0000000
        </p>
       </div>
     </div>
    </div>


    <div class="pagination-container">
        <ul class="page">
            <li class="active"><a href="#">1</a></li>
            <li><a href="#">2</a></li>
            <li><a href="#">3</a></li>
            <li><a href="#">></a></li>
        </ul>
    </div>
    </main>

    <footer>
        <title>
            Footer Section
        </title>
           <script src="https://cdn.tailwindcss.com">
           </script>
          <body class="bg-white">
           <footer class="bg-black text-white py-10">
            <div class="container mx-auto px-4 flex flex-col md:flex-row justify-between">
             <div class="mb-8 md:mb-0">
              <img alt="" class="mb-4" height="50" src="#" width="150"/>
              <p class="mb-4">
               From the words you live by to the culture you cherish, we turn your language into wearable art —because every jersey should tell your story.
              </p>
              <p class="mb-2">
               Atha 7 Apparel
              </p>
              <p class="mb-2">
               CONTACT US:
              </p>
              <div class="flex items-center">
               <i class="fab fa-whatsapp text-2xl mr-2">
               </i>
               <span>
                087777513640
               </span>
              </div>
             </div>
             <div class="mb-8 md:mb-0">
              <h3 class="mb-4">
               CUSTOMER SERVICE
              </h3>
              <p class="mb-2">
               FAQ
              </p>
              <p>
               Sistem Pemesanan
              </p>
             </div>
             <div>
              <h3 class="mb-4">
               SOCIAL MEDIA
              </h3>
              <div class="flex space-x-4">
               <i class="fab fa-instagram text-2xl">
               </i>
               <i class="fab fa-tiktok text-2xl">
               </i>
              </div>
             </div>
            </div>      
    </footer>
</body>
</html>