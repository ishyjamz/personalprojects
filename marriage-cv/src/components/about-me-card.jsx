import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import Hridoy from '../images/hridoy.png';
import { Link } from 'react-router-dom';

function AboutMeCard() {
  return (
    <>
      <Card>
        <Card.Img className='pic' variant="top" src={Hridoy} alt='Pink' />
        <Card.Body>
          <Card.Title>About Me</Card.Title>
          <Card.Text>
            Find out more about who I am as a person - my values, my hobbies, my personality,
            what I may look for in a partner etc.
            <br/>
            <br/>
          </Card.Text>
        </Card.Body>
        <Card.Footer className='justify-content-center'>
          <Link to='/about-me'><Button id='click-here'>Click Here</Button></Link>
        </Card.Footer>
      </Card>
    </>

  );
}

export default AboutMeCard