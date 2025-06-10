// Toggle between login and signup forms
document.getElementById('showSignup').onclick = function() {
  document.getElementById('loginForm').classList.add('hidden');
  document.getElementById('signupForm').classList.remove('hidden');
  document.getElementById('errorMsg').textContent = '';
};
document.getElementById('showLogin').onclick = function() {
  document.getElementById('signupForm').classList.add('hidden');
  document.getElementById('loginForm').classList.remove('hidden');
  document.getElementById('errorMsg').textContent = '';
};

// Login logic
document.getElementById('loginForm').addEventListener('submit', function(e) {
  e.preventDefault();
  const user = document.getElementById('loginUser').value.trim();
  const pass = document.getElementById('loginPass').value;
  if (pass.length < 4 || pass.length > 6) {
    document.getElementById('errorMsg').textContent = 'Password must be between 4 and 6 characters.';
    return;
  }
  const storedUser = localStorage.getItem('user');
  const storedPass = localStorage.getItem('pass');
  if (user === storedUser && pass === storedPass) {
    document.getElementById('errorMsg').textContent = '';
    // Show dashboard without redirect
    showDashboard(user);
  } else {
    document.getElementById('errorMsg').textContent = 'Invalid credentials!';
  }
});

// Signup logic
document.getElementById('signupForm').addEventListener('submit', function(e) {
  e.preventDefault();
  const user = document.getElementById('signupUser').value.trim();
  const pass = document.getElementById('signupPass').value;
  if (pass.length < 4 || pass.length > 6) {
    document.getElementById('errorMsg').textContent = 'Password must be between 4 and 6 characters.';
    return;
  }
  localStorage.setItem('user', user);
  localStorage.setItem('pass', pass);
  document.getElementById('errorMsg').textContent = 'Signup successful! Please login.';
  setTimeout(() => {
    document.getElementById('signupForm').classList.add('hidden');
    document.getElementById('loginForm').classList.remove('hidden');
    document.getElementById('errorMsg').textContent = '';
  }, 1200);
});

// Dashboard rendering (in-page, no redirect)
function showDashboard(username) {
  document.body.style.background = "linear-gradient(135deg, #181818 60%, #232323 100%)";
  document.getElementById('mainContainer').innerHTML = `
    <div class="logo">&#128375;</div>
    <h1>Welcome, ${username}!</h1>
    <div class="media-section">
      <div class="media-tabs">
        <button class="media-tab" id="videosTab">Videos</button>
        <button class="media-tab" id="picturesTab">Pictures</button>
      </div>
      <div id="videosList" class="media-list" style="display:none;">
        <div class="media-item">
          <div class="media-title">Cartoon Sample</div>
          <video controls poster="images/video-thumb1.jpg">
            <source src="videos/cartoon.mp4" type="video/mp4">
            Your browser does not support the video tag.
          </video>
        </div>
        <div class="media-item">
          <div class="media-title">Movie Sample</div>
          <video controls poster="images/video-thumb2.jpg">
            <source src="videos/movie.mp4" type="video/mp4">
            Your browser does not support the video tag.
          </video>
        </div>
      </div>
      <div id="picturesList" class="media-list" style="display:none;">
        <div class="media-item">
          <div class="media-title">Nature Picture</div>
          <img src="images/nature.jpg" alt="Nature Picture">
        </div>
        <div class="media-item">
          <div class="media-title">City Picture</div>
          <img src="images/city.jpg" alt="City Picture">
        </div>
      </div>
    </div>
    <button class="logout-btn" id="logoutBtn">Logout</button>
    <div class="footer">&copy; 2025 Black Spider. All rights reserved.</div>
  `;
  // Tab switching logic
  const videosTab = document.getElementById('videosTab');
  const picturesTab = document.getElementById('picturesTab');
  const videosList = document.getElementById('videosList');
  const picturesList = document.getElementById('picturesList');
  videosList.style.display = 'none';
  picturesList.style.display = 'none';
  videosTab.onclick = function() {
    videosTab.classList.add('active');
    picturesTab.classList.remove('active');
    videosList.style.display = '';
    picturesList.style.display = 'none';
  };
  picturesTab.onclick = function() {
    picturesTab.classList.add('active');
    videosTab.classList.remove('active');
    picturesList.style.display = '';
    videosList.style.display = 'none';
  };
  document.getElementById('logoutBtn').onclick = function() {
    window.location.reload();
  };
}