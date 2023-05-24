contacts = {
    'number': 4,
    'students':
        [
            {'name': 'Graham Ziyaanson', 'email': 'graham@example.com'},
            {'name': 'Cheesy Grapes', 'email': 'frimpong@coolbeans.co.uk'},
            {'name': 'Mohamed Hoblos', 'email': 'dagoat@coolbeans.co.uk'},
            {'name': 'Dr Zakir Naik', 'email': 'goatstatus@coolbeans.co.uk'}
        ]
}

print('Student emails:')
for student in contacts['students']:
    print(student['email'])

