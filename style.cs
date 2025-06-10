body {
  background: radial-gradient(ellipse at top left, #232323 0%, #181818 100%);
  color: #f5f5f5;
  font-family: 'Segoe UI', Arial, sans-serif;
  margin: 0;
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  overflow-x: hidden;
}
.container {
  background: rgba(34,34,34,0.98);
  padding: 2.7rem 2.2rem 2.2rem 2.2rem;
  margin: 3vh auto;
  max-width: 400px;
  border-radius: 18px;
  box-shadow: 0 8px 40px #000c, 0 1.5px 0 #333 inset;
  text-align: center;
  animation: fadeIn 0.8s;
  position: relative;
}
.logo {
  font-size: 3.5rem;
  margin-bottom: 0.7rem;
  filter: drop-shadow(0 0 12px #000);
  user-select: none;
  animation: spin 2.5s linear infinite alternate;
  display: inline-block;
  color: #fff;
  text-shadow: 0 0 16px #000a;
}
@keyframes spin {
  0% { transform: rotate(-10deg);}
  100% { transform: rotate(10deg);}
}
h1 {
  margin-bottom: 1.5rem;
  letter-spacing: 2px;
  font-size: 2.2rem;
  font-weight: 900;
  text-shadow: 0 2px 16px #000a;
  background: linear-gradient(90deg, #fff 60%, #888 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  background-clip: text;
}
#errorMsg {
  color: #ff6b6b;
  margin-bottom: 1rem;
  min-height: 1.5em;
  font-size: 1rem;
  font-weight: 500;
  letter-spacing: 1px;
  transition: color 0.2s;
}
form input {
  display: block;
  width: 92%;
  margin: 1rem auto;
  padding: 0.95rem;
  background: #111;
  color: #f5f5f5;
  border: 1.5px solid #444;
  border-radius: 7px;
  font-size: 1.13rem;
  transition: border 0.2s, box-shadow 0.2s;
  box-shadow: 0 1px 8px #0003;
  font-family: inherit;
}
form input:focus, form button:focus {
  outline: 2px solid #888;
  outline-offset: 2px;
  border-color: #888;
  box-shadow: 0 2px 12px #0006;
}
form button {
  width: 96%;
  padding: 1.05rem;
  margin: 1.2rem 0 0.5rem 0;
  background: linear-gradient(90deg, #333 60%, #444 100%);
  color: #fff;
  border: none;
  border-radius: 7px;
  font-weight: bold;
  font-size: 1.18rem;
  cursor: pointer;
  transition: background 0.2s, transform 0.13s, box-shadow 0.2s;
  box-shadow: 0 2px 12px #0005;
  letter-spacing: 1.5px;
}
form button:hover {
  background: linear-gradient(90deg, #444 60%, #333 100%);
  transform: translateY(-2px) scale(1.045);
  box-shadow: 0 4px 20px #0008;
}
.toggle-link {
  color: #aaa;
  text-decoration: underline;
  cursor: pointer;
  display: block;
  margin-top: 1rem;
  font-size: 1.05rem;
  transition: color 0.2s;
  font-weight: 500;
}
.toggle-link:hover {
  color: #fff;
  text-decoration: none;
}
.hidden {
  display: none;
}
.footer {
  margin-top: 2.5rem;
  font-size: 0.97rem;
  color: #888;
  letter-spacing: 1px;
  opacity: 0.7;
  border-top: 1px solid #333;
  padding-top: 1.2rem;
}

/* Dashboard styles */
.media-section {
  margin: 2.2rem 0 0.5rem 0;
}
.media-tabs {
  display: flex;
  justify-content: center;
  gap: 1.5rem;
  margin-bottom: 1.5rem;
}
.media-tab {
  background: #232323;
  color: #fff;
  border: none;
  border-radius: 7px;
  padding: 0.9rem 2.3rem;
  font-size: 1.13rem;
  cursor: pointer;
  font-weight: 700;
  letter-spacing: 1px;
  box-shadow: 0 2px 8px #0003;
  transition: background 0.2s, color 0.2s, transform 0.15s;
}
.media-tab.active, .media-tab:hover {
  background: #444;
  color: #fff;
  transform: scale(1.08);
}
.media-list {
  display: flex;
  flex-wrap: wrap;
  gap: 1.5rem;
  justify-content: center;
  background: #181818;
  border-radius: 12px;
  padding: 1.5rem 0.5rem;
  margin-bottom: 1rem;
  box-shadow: 0 2px 14px #0005;
  animation: fadeIn 0.7s;
}
.media-item {
  background: #232323;
  border-radius: 12px;
  box-shadow: 0 2px 14px #0007;
  padding: 1rem 1rem 0.7rem 1rem;
  text-align: center;
  width: 320px;
  transition: transform 0.18s, box-shadow 0.18s;
}
.media-item:hover {
  transform: translateY(-6px) scale(1.04);
  box-shadow: 0 8px 32px #000b;
}
.media-item video, .media-item img {
  width: 100%;
  border-radius: 9px;
  margin-bottom: 0.7rem;
  background: #111;
  box-shadow: 0 2px 8px #0006;
}
.media-title {
  color: #e0e0e0;
  font-size: 1.15rem;
  margin-bottom: 0.3rem;
  font-weight: 700;
  letter-spacing: 1px;
}
button.logout-btn {
  margin-top: 2.2rem;
  background: #232323;
  color: #bbb;
  border: none;
  border-radius: 7px;
  padding: 0.9rem 2.5rem;
  font-size: 1.13rem;
  font-weight: 700;
  cursor: pointer;
  transition: background 0.2s, color 0.2s, transform 0.15s;
  box-shadow: 0 2px 8px #0003;
  letter-spacing: 1px;
}
button.logout-btn:hover {
  background: #333;
  color: #fff;
  transform: scale(1.06);
}
@media (max-width: 500px) {
  .container {
    padding: 1.2rem 0.5rem 1rem 0.5rem;
    max-width: 98vw;
  }
  h1 {
    font-size: 1.3rem;
  }
  .logo {
    font-size: 2rem;
  }
  .media-item {
    width: 98vw;
    max-width: 350px;
    margin: 0 auto;
  }
  .media-list {
    flex-direction: column;
    gap: 1rem;
  }
}
@keyframes fadeIn {
  from { opacity: 0; transform: translateY(30px);}
  to { opacity: 1; transform: translateY(0);}
}
@keyframes spin {
  0% { transform: rotate(-10deg);}
  100% { transform: rotate(10deg);}
}