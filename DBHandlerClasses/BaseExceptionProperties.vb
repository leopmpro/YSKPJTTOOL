Public Class BaseExceptionProperties
    Protected mHasException As Boolean

    Public ReadOnly Property HasException As Boolean
        Get
            Return mHasException
        End Get
    End Property

    Protected mLastException As Exception
    Public ReadOnly Property LastException As Exception
        Get
            Return mLastException
        End Get
    End Property

    Public ReadOnly Property LastExceptionMessage As String
        Get
            Return mLastException.Message
        End Get
    End Property

    Public ReadOnly Property IsSuccessFul As Boolean
        Get
            Return Not mHasException
        End Get
    End Property

End Class
