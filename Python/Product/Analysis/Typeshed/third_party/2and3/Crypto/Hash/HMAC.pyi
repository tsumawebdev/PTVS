from typing import Any, Optional

digest_size = ...  # type: Any

class HMAC:
    digest_size = ...  # type: Any
    digestmod = ...  # type: Any
    outer = ...  # type: Any
    inner = ...  # type: Any
    def __init__(self, key, msg: Optional[Any] = ..., digestmod: Optional[Any] = ...) -> None: ...
    def update(self, msg): ...
    def copy(self): ...
    def digest(self): ...
    def hexdigest(self): ...

def new(key, msg: Optional[Any] = ..., digestmod: Optional[Any] = ...): ...
