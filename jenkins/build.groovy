pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                bat '''
                    dotnet build --configuration Release
                '''
            }
        }
    }
    post {
        always {
            echo 'Delete directory'
            deleteDir()
        }
    }
}
