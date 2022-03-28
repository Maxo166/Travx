import logo from '../images/logo.svg';
import './App.css';
import Navbar from '../components/navbar';
import JobLists from '../components/jobLists';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap/dist/js/bootstrap.esm'
import {
    BrowserRouter as Router,
    Routes,
    Route,
    Link
} from 'react-router-dom'


function App() {
  return (
    <Router className="App">
      <Navbar lable1='Sign in' lablel2='Sign up!'/>
      <div class="container">
        <JobLists />
      </div>
    </Router>
  );
}

export default App;
