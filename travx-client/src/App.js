import logo from './logo.svg';
import './App.css';
import Navbar from './components/Navbar';
import JobLists from './components/JobLists';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap/dist/js/bootstrap.esm'



function App() {
  return (
    <div className="App">
      <Navbar />
      <div class="container-fluid">
        <JobLists></JobLists>
      </div>
    </div>
  );
}

export default App;
