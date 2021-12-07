import { Route, Routes } from "react-router";
import Header from "./components/Header/Header.js";
import WelcomeWorld from "./components/WelcomeWorld/WelcomeWorld.js";

function App() {
  return (
    <div>
      <div id="box">
        <Header/>

        <main id="main-content">
           <Routes>
             <Route path="/" element={<WelcomeWorld/>}/>
           </Routes>
        </main>
        
      </div>
    </div>
  );
}

export default App;
