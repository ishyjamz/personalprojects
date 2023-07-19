import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import Grad from '../images/grad.jpg';

function EducationCard() {
  return (
    <Card>
      <Card.Img className='pic' variant="top" src={Grad} alt='' />
      <Card.Body>
        <Card.Title>Education</Card.Title>
        <Card.Text>
            I know education is important to a lot of parents, 
            so take a look through this section to learn more about
            my education history and see if it aligns with your expectations
        </Card.Text>
      </Card.Body>
      <Card.Footer>
          <Button id='click-here'>Click Here</Button>
        </Card.Footer>
    </Card>
  );
}

export default EducationCard