import { Route, Routes } from "react-router";
import Header from "./components/Header/Header.js";
import WelcomeWorld from "./components/WelcomeWorld/WelcomeWorld.js";
import MealDetails from "./components/MealDetails/MealDetails.js";

function App() {
  return (
    <div>
      <div id="box">
        <Header/>

        <main id="main-content">
           <Routes>
             <Route path="/" element={<WelcomeWorld/>}/>
             <Route path="/meal-details" element={<MealDetails/>}/>
           </Routes>
        </main>
        
      </div>
    </div>
  );
}

export default App;
