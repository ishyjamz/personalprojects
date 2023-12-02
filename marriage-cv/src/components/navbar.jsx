import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import { Link } from 'react-router-dom';
import { List } from 'react-bootstrap-icons';
import { Button } from 'react-bootstrap';
import './navbar.css';

export function NavBar() {
  return (
    <Navbar expand="lg" className="justify-content-center">
      <Navbar.Brand className='ms-3' href="#home"><List /> Ishy's Marriage CV</Navbar.Brand>
      <Navbar.Toggle aria-controls="basic-navbar-nav" />
      <Navbar.Collapse className='justify-content-center' id="basic-navbar-nav">
        <Nav id='links' className='justify-content-center'>
          <Link className='nav-link' to='/'>Home</Link>
          <Link className='nav-link' to='/about-me'>About Me</Link>
          <Link className='nav-link' to='/education'>Education</Link>
          <Link className='nav-link' to='/fun-questions'>Fun Questions</Link>
        </Nav>
      </Navbar.Collapse>
      <Navbar.Collapse className='justify-content-end'>
        <Link className='nav-link me-3' to='/apply'>
          <Button>
            Apply Now
          </Button>
        </Link>
      </Navbar.Collapse>
    </Navbar>
  );
}

export default NavBar;